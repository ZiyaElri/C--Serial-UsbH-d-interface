namespace SerialConnect1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelPort = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.comboBoxSerialPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisConnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonUsbHıd = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(12, 18);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(31, 16);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Port";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(163, 18);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(62, 16);
            this.labelBaudRate.TabIndex = 1;
            this.labelBaudRate.Text = "Baudrate";
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.FormattingEnabled = true;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(49, 15);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Size = new System.Drawing.Size(90, 24);
            this.comboBoxSerialPort.TabIndex = 2;
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Items.AddRange(new object[] {
            "75",
            "110",
            "134",
            "150",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.comboBoxBaudrate.Location = new System.Drawing.Point(231, 15);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(91, 24);
            this.comboBoxBaudrate.TabIndex = 3;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(330, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(103, 28);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisConnect
            // 
            this.buttonDisConnect.Location = new System.Drawing.Point(439, 12);
            this.buttonDisConnect.Name = "buttonDisConnect";
            this.buttonDisConnect.Size = new System.Drawing.Size(100, 28);
            this.buttonDisConnect.TabIndex = 5;
            this.buttonDisConnect.Text = "Disconnect";
            this.buttonDisConnect.UseVisualStyleBackColor = true;
            this.buttonDisConnect.Click += new System.EventHandler(this.buttonDisConnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 90);
            this.textBox1.TabIndex = 6;
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(444, 81);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(95, 33);
            this.buttonRead.TabIndex = 7;
            this.buttonRead.Text = "Serial Oku";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonUniqueId_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(444, 46);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(95, 29);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonUsbHıd
            // 
            this.buttonUsbHıd.Location = new System.Drawing.Point(12, 159);
            this.buttonUsbHıd.Name = "buttonUsbHıd";
            this.buttonUsbHıd.Size = new System.Drawing.Size(95, 33);
            this.buttonUsbHıd.TabIndex = 9;
            this.buttonUsbHıd.Text = "UsbHID";
            this.buttonUsbHıd.UseVisualStyleBackColor = true;
            this.buttonUsbHıd.Click += new System.EventHandler(this.buttonUsbHıd_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 22);
            this.textBox2.TabIndex = 10;
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(444, 120);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(95, 33);
            this.buttonWrite.TabIndex = 11;
            this.buttonWrite.Text = "Serial Yaz";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 207);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonUsbHıd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDisConnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxBaudrate);
            this.Controls.Add(this.comboBoxSerialPort);
            this.Controls.Add(this.labelBaudRate);
            this.Controls.Add(this.labelPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.ComboBox comboBoxSerialPort;
        private System.Windows.Forms.ComboBox comboBoxBaudrate;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisConnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonUsbHıd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonWrite;
    }
}

