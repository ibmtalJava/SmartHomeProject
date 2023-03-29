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
            this.lightsListBox.Location = new System.Drawing.Point(361, 41);
            this.lightsListBox.Name = "lightsListBox";
            this.lightsListBox.Size = new System.Drawing.Size(120, 225);
            this.lightsListBox.TabIndex = 13;
            // 
            // lightsTimer
            // 
            this.lightsTimer.Enabled = true;
            this.lightsTimer.Interval = 2000;
            this.lightsTimer.Tick += new System.EventHandler(this.lightsTimer_Tick);
            // 
            // lightArduinoSend
            // 
            this.lightArduinoSend.Enabled = true;
            this.lightArduinoSend.Tick += new System.EventHandler(this.lightArduinoSend_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

