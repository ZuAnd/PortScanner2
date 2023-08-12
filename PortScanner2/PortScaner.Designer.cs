namespace PortScanner2
{
    partial class PortScaner
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nmBeginPort = new NumericUpDown();
            nmEndPort = new NumericUpDown();
            btnScan = new Button();
            textBox1 = new TextBox();
            lvPorts = new ListView();
            Port = new ColumnHeader();
            OpenPort = new ColumnHeader();
            ClosePort = new ColumnHeader();
            pb = new ProgressBar();
            lbedIP = new Label();
            lbStartPort = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmBeginPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmEndPort).BeginInit();
            SuspendLayout();
            // 
            // nmBeginPort
            // 
            nmBeginPort.Location = new Point(365, 25);
            nmBeginPort.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nmBeginPort.Name = "nmBeginPort";
            nmBeginPort.Size = new Size(120, 23);
            nmBeginPort.TabIndex = 0;
            // 
            // nmEndPort
            // 
            nmEndPort.Location = new Point(491, 25);
            nmEndPort.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nmEndPort.Name = "nmEndPort";
            nmEndPort.Size = new Size(120, 23);
            nmEndPort.TabIndex = 1;
            // 
            // btnScan
            // 
            btnScan.Location = new Point(617, 25);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(171, 23);
            btnScan.TabIndex = 2;
            btnScan.Text = "Сканировать";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 23);
            textBox1.TabIndex = 3;
            // 
            // lvPorts
            // 
            lvPorts.Columns.AddRange(new ColumnHeader[] { Port, OpenPort, ClosePort });
            lvPorts.Location = new Point(12, 55);
            lvPorts.Name = "lvPorts";
            lvPorts.Size = new Size(776, 358);
            lvPorts.TabIndex = 4;
            lvPorts.UseCompatibleStateImageBehavior = false;
            lvPorts.View = View.Details;
            // 
            // Port
            // 
            Port.Text = "Порт";
            Port.Width = 240;
            // 
            // OpenPort
            // 
            OpenPort.Text = "Открыт";
            OpenPort.Width = 240;
            // 
            // ClosePort
            // 
            ClosePort.Text = "Закрыт";
            ClosePort.Width = 240;
            // 
            // pb
            // 
            pb.Location = new Point(12, 419);
            pb.Name = "pb";
            pb.Size = new Size(776, 23);
            pb.TabIndex = 5;
            // 
            // lbedIP
            // 
            lbedIP.AutoSize = true;
            lbedIP.Location = new Point(12, 8);
            lbedIP.Name = "lbedIP";
            lbedIP.Size = new Size(57, 15);
            lbedIP.TabIndex = 6;
            lbedIP.Text = "IP адресс";
            // 
            // lbStartPort
            // 
            lbStartPort.AutoSize = true;
            lbStartPort.Location = new Point(365, 7);
            lbStartPort.Name = "lbStartPort";
            lbStartPort.Size = new Size(100, 15);
            lbStartPort.TabIndex = 7;
            lbStartPort.Text = "Начальный порт";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 7);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 8;
            label2.Text = "Конечный порт";
            // 
            // PortScaner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lbStartPort);
            Controls.Add(lbedIP);
            Controls.Add(pb);
            Controls.Add(lvPorts);
            Controls.Add(textBox1);
            Controls.Add(btnScan);
            Controls.Add(nmEndPort);
            Controls.Add(nmBeginPort);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "PortScaner";
            Text = "Сканер  портов";
            ((System.ComponentModel.ISupportInitialize)nmBeginPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmEndPort).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nmBeginPort;
        private NumericUpDown nmEndPort;
        private Button btnScan;
        private TextBox textBox1;
        private ListView lvPorts;
        private ProgressBar pb;
        private ColumnHeader Port;
        private ColumnHeader OpenPort;
        private ColumnHeader ClosePort;
        private Label lbedIP;
        private Label lbStartPort;
        private Label label2;
    }
}