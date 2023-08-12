using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;

namespace PortScanner2
{
    public partial class PortScaner : Form
    {
        public PortScaner()
        {
            InitializeComponent();
        }
        bool IsScaning = false;

        public void Scan()
        {
            IsScaning = true;
            int StartPort = Convert.ToInt32(nmBeginPort.Value);
            int EndPort = Convert.ToInt32(nmEndPort.Value);
            int i;

            pb.Maximum = EndPort - StartPort + 1;
            pb.Value = 0;
            lvPorts.Items.Clear();

            IPAddress IpAddr = IPAddress.Parse(textBox1.Text);
            Thread MyThread = new Thread(new ThreadStart(() =>
            {
                Parallel.For(StartPort, EndPort, (i, state) =>
                {
                    //Создаем сокет
                    IPEndPoint IpEndP = new IPEndPoint(IpAddr, i);
                    Socket MySoc = new Socket(AddressFamily.InterNetwork,
                                             SocketType.Stream, ProtocolType.Tcp);
                    //Пробуем подключится к указанному хосту
                    IAsyncResult asyncResult = MySoc.BeginConnect(IpEndP,
                                     new AsyncCallback(ConnectCallback), MySoc);

                    if (!asyncResult.AsyncWaitHandle.WaitOne(2000, false))
                    {
                        MySoc.Close();

                        var threadParameters1 = new System.Threading.ThreadStart(delegate { WriteListBox(i, StartPort, false); });
                        var thread1 = new System.Threading.Thread(threadParameters1);
                        thread1.Start();
                    }
                    else
                    {
                        MySoc.Close();

                        var threadParameters2 = new System.Threading.ThreadStart(delegate { WriteListBox(i, StartPort, true); });
                        var thread2 = new System.Threading.Thread(threadParameters2);
                        thread2.Start();
                    }
                    if(!IsScaning)
                    {
                        state.Break();
                        var threadParameters3 = new System.Threading.ThreadStart(delegate { ClearProgress(); });
                        var thread3= new System.Threading.Thread(threadParameters3);
                        thread3.Start();
                    }
                        
                });
            }));
            MyThread.Start();

        }

        public void  ClearProgress() 
        {           
            if (lvPorts.InvokeRequired)
            {
                // Call this same method but append THREAD2 to the text
                Action safeWrite = delegate { ClearProgress(); };
                pb.Invoke(safeWrite);
            }
            else
                pb.Value = 0;
        }

        int i = 1;
        public void WriteListBox(int port, int startPort, bool OpenClose)
        {            
            if (lvPorts.InvokeRequired)
            {
                // Call this same method but append THREAD2 to the text
                Action safeWrite = delegate { WriteListBox(port, startPort, OpenClose); };
                lvPorts.Invoke(safeWrite);
            }
            else
            {
                if (OpenClose)
                {

                    lvPorts.Items.Add("Порт " + port.ToString());
                    lvPorts.Items[lvPorts.Items.Count - 1].SubItems.Add("открыт");
                    lvPorts.Items[lvPorts.Items.Count - 1].BackColor = Color.LightGreen;
                    pb.Value += 1;

                    if (i == nmEndPort.Value-1)
                    {
                        pb.Value = 0;
                        IsScaning = false;

                    }
                    i++;
                }
                else
                {
                    pb.Value += 1;
                    
                    if (i == nmEndPort.Value-1)
                    {
                        pb.Value = 0;
                        IsScaning = false;
                        btnScan.Text = "Сканировать";
                    }
                    i++;
                }
            }

        }
        public static ManualResetEvent connectDone = new ManualResetEvent(false);
        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;
                client.EndConnect(ar);
                connectDone.Set();
            }
            catch (Exception e)
            {

            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (!IsScaning)
            {
                Scan();
                btnScan.Text = "Отменить";
            }
            else
            {
                IsScaning = false;
                btnScan.Text = "Сканировать";

            }
        }
    }


}


