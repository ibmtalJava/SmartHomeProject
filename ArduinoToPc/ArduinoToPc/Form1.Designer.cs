namespace ArduinoToPc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.portName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portBautRate = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.connectStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modul = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.action = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.data1 = new System.Windows.Forms.TextBox();
            this.data2 = new System.Windows.Forms.TextBox();
            this.data3 = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gelenveri = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lightsListBox = new System.Windows.Forms.ListBox();
            this.lightsTimer = new System.Windows.Forms.Timer(this.components);
            this.lightArduinoSend = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.camsTimer = new System.Windows.Forms.Timer(this.components);
            this.camArduinoTimer = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.seraSicaklik = new System.Windows.Forms.TextBox();
            this.seraNem = new System.Windows.Forms.TextBox();
            this.seraSuSeviyesi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dog1 = new System.Windows.Forms.TextBox();
            this.dog2 = new System.Windows.Forms.TextBox();
            this.dog3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // portName
            // 
            this.portName.Location = new System.Drawing.Point(84, 41);
            this.portName.Name = "portName";
            this.portName.Size = new System.Drawing.Size(100, 20);
            this.portName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "BautRate";
            // 
            // portBautRate
            // 
            this.portBautRate.Location = new System.Drawing.Point(84, 78);
            this.portBautRate.Name = "portBautRate";
            this.portBautRate.Size = new System.Drawing.Size(100, 20);
            this.portBautRate.TabIndex = 3;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(39, 114);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(80, 27);
            this.connectBtn.TabIndex = 4;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // connectStatus
            // 
            this.connectStatus.AutoSize = true;
            this.connectStatus.Location = new System.Drawing.Point(42, 159);
            this.connectStatus.Name = "connectStatus";
            this.connectStatus.Size = new System.Drawing.Size(35, 13);
            this.connectStatus.TabIndex = 5;
            this.connectStatus.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modül";
            // 
            // modul
            // 
            this.modul.Location = new System.Drawing.Point(83, 189);
            this.modul.Name = "modul";
            this.modul.Size = new System.Drawing.Size(100, 20);
            this.modul.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Action";
            // 
            // action
            // 
            this.action.Location = new System.Drawing.Point(83, 220);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(100, 20);
            this.action.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Data3";
            // 
            // data1
            // 
            this.data1.Location = new System.Drawing.Point(83, 256);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(100, 20);
            this.data1.TabIndex = 9;
            // 
            // data2
            // 
            this.data2.Location = new System.Drawing.Point(83, 285);
            this.data2.Name = "data2";
            this.data2.Size = new System.Drawing.Size(100, 20);
            this.data2.TabIndex = 9;
            // 
            // data3
            // 
            this.data3.Location = new System.Drawing.Point(83, 317);
            this.data3.Name = "data3";
            this.data3.Size = new System.Drawing.Size(100, 20);
            this.data3.TabIndex = 9;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(52, 355);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(130, 25);
            this.sendButton.TabIndex = 11;
            this.sendButton.Text = "SEND";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(125, 114);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(80, 27);
            this.disconnect.TabIndex = 4;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gelenveri
            // 
            this.gelenveri.AutoSize = true;
            this.gelenveri.Location = new System.Drawing.Point(30, 413);
            this.gelenveri.Name = "gelenveri";
            this.gelenveri.Size = new System.Drawing.Size(35, 13);
            this.gelenveri.TabIndex = 12;
            this.gelenveri.Text = "label8";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get Api";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lightsListBox
            // 
            this.lightsListBox.FormattingEnabled = true;
            this.lightsListBox.Location = new System.Drawing.Point(691, 28);
            this.lightsListBox.Name = "lightsListBox";
            this.lightsListBox.Size = new System.Drawing.Size(67, 225);
            this.lightsListBox.TabIndex = 13;
            // 
            // lightsTimer
            // 
            this.lightsTimer.Interval = 10000;
            this.lightsTimer.Tick += new System.EventHandler(this.lightsTimer_Tick);
            // 
            // lightArduinoSend
            // 
            this.lightArduinoSend.Interval = 2000;
            this.lightArduinoSend.Tick += new System.EventHandler(this.lightArduinoSend_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(565, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 212);
            this.listBox1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // camsTimer
            // 
            this.camsTimer.Enabled = true;
            this.camsTimer.Interval = 13000;
            this.camsTimer.Tick += new System.EventHandler(this.camsTimer_Tick);
            // 
            // camArduinoTimer
            // 
            this.camArduinoTimer.Enabled = true;
            this.camArduinoTimer.Interval = 2400;
            this.camArduinoTimer.Tick += new System.EventHandler(this.camArduinoTimer_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "SERA Verileri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sıcaklık";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nem";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Su Seviyesi";
            // 
            // seraSicaklik
            // 
            this.seraSicaklik.Location = new System.Drawing.Point(266, 220);
            this.seraSicaklik.Name = "seraSicaklik";
            this.seraSicaklik.Size = new System.Drawing.Size(100, 20);
            this.seraSicaklik.TabIndex = 20;
            // 
            // seraNem
            // 
            this.seraNem.Location = new System.Drawing.Point(266, 258);
            this.seraNem.Name = "seraNem";
            this.seraNem.Size = new System.Drawing.Size(100, 20);
            this.seraNem.TabIndex = 21;
            // 
            // seraSuSeviyesi
            // 
            this.seraSuSeviyesi.Location = new System.Drawing.Point(287, 288);
            this.seraSuSeviyesi.Name = "seraSuSeviyesi";
            this.seraSuSeviyesi.Size = new System.Drawing.Size(100, 20);
            this.seraSuSeviyesi.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(384, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Su Kapları";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(357, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Golden";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(357, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Doberman";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(358, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Kangal";
            // 
            // dog1
            // 
            this.dog1.Location = new System.Drawing.Point(416, 102);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(100, 20);
            this.dog1.TabIndex = 27;
            // 
            // dog2
            // 
            this.dog2.Location = new System.Drawing.Point(416, 128);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(100, 20);
            this.dog2.TabIndex = 28;
            // 
            // dog3
            // 
            this.dog3.Location = new System.Drawing.Point(416, 156);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(100, 20);
            this.dog3.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.seraSuSeviyesi);
            this.Controls.Add(this.seraNem);
            this.Controls.Add(this.seraSicaklik);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lightsListBox);
            this.Controls.Add(this.gelenveri);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.data3);
            this.Controls.Add(this.data2);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.action);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.connectStatus);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.portBautRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox portName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portBautRate;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label connectStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox action;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox data1;
        private System.Windows.Forms.TextBox data2;
        private System.Windows.Forms.TextBox data3;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label gelenveri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lightsListBox;
        private System.Windows.Forms.Timer lightsTimer;
        private System.Windows.Forms.Timer lightArduinoSend;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer camsTimer;
        private System.Windows.Forms.Timer camArduinoTimer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox seraSicaklik;
        private System.Windows.Forms.TextBox seraNem;
        private System.Windows.Forms.TextBox seraSuSeviyesi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox dog1;
        private System.Windows.Forms.TextBox dog2;
        private System.Windows.Forms.TextBox dog3;
    }
}

