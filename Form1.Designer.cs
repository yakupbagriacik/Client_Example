namespace Client_Example
{
    partial class Form1
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
            txtIP = new TextBox();
            lblIP = new Label();
            txtPort = new TextBox();
            lblPort = new Label();
            btnSend = new Button();
            btnDisconnect = new Button();
            btnConnect = new Button();
            txtMessage = new TextBox();
            txtReceived = new TextBox();
            lblReceive = new Label();
            lblSend = new Label();
            SuspendLayout();
            // 
            // txtIP
            // 
            txtIP.Location = new Point(41, 25);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(100, 23);
            txtIP.TabIndex = 5;
            // 
            // lblIP
            // 
            lblIP.AutoSize = true;
            lblIP.Location = new Point(13, 29);
            lblIP.Name = "lblIP";
            lblIP.Size = new Size(20, 15);
            lblIP.TabIndex = 4;
            lblIP.Text = "IP:";
            lblIP.Click += label2_Click;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(186, 25);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(100, 23);
            txtPort.TabIndex = 7;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(148, 28);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(32, 15);
            lblPort.TabIndex = 6;
            lblPort.Text = "Port:";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(445, 210);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 12;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(412, 26);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(108, 23);
            btnDisconnect.TabIndex = 13;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(308, 26);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(88, 23);
            btnConnect.TabIndex = 14;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(41, 73);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ScrollBars = ScrollBars.Vertical;
            txtMessage.Size = new Size(479, 122);
            txtMessage.TabIndex = 15;
            txtMessage.WordWrap = false;
            txtMessage.TextChanged += txtMessage_TextChanged;
            // 
            // txtReceived
            // 
            txtReceived.Location = new Point(41, 247);
            txtReceived.Multiline = true;
            txtReceived.Name = "txtReceived";
            txtReceived.ScrollBars = ScrollBars.Both;
            txtReceived.Size = new Size(479, 241);
            txtReceived.TabIndex = 16;
            txtReceived.WordWrap = false;
            // 
            // lblReceive
            // 
            lblReceive.AutoSize = true;
            lblReceive.Location = new Point(41, 229);
            lblReceive.Name = "lblReceive";
            lblReceive.Size = new Size(47, 15);
            lblReceive.TabIndex = 20;
            lblReceive.Text = "Receive";
            // 
            // lblSend
            // 
            lblSend.AutoSize = true;
            lblSend.Location = new Point(41, 55);
            lblSend.Name = "lblSend";
            lblSend.Size = new Size(33, 15);
            lblSend.TabIndex = 21;
            lblSend.Text = "Send";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 513);
            Controls.Add(lblSend);
            Controls.Add(lblReceive);
            Controls.Add(txtReceived);
            Controls.Add(txtMessage);
            Controls.Add(btnConnect);
            Controls.Add(btnDisconnect);
            Controls.Add(btnSend);
            Controls.Add(txtPort);
            Controls.Add(lblPort);
            Controls.Add(txtIP);
            Controls.Add(lblIP);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtIP;
        private Label lblIP;
        private TextBox txtPort;
        private Label lblPort;
        private Button btnSend;
        private Button btnDisconnect;
        private Button btnConnect;
        private TextBox txtMessage;
        private TextBox txtReceived;
        private Label lblReceive;
        private Label lblSend;
    }
}
