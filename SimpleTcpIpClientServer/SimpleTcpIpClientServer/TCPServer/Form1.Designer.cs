namespace SimpleTcpIpClientServer
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxIp = new System.Windows.Forms.TextBox();
            this.txtBoxInfo = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBoxMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listClientIP = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(378, 310);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // txtBoxIp
            // 
            this.txtBoxIp.Location = new System.Drawing.Point(76, 33);
            this.txtBoxIp.Name = "txtBoxIp";
            this.txtBoxIp.Size = new System.Drawing.Size(377, 23);
            this.txtBoxIp.TabIndex = 2;
            this.txtBoxIp.Text = "127.0.0.1:9000";
            // 
            // txtBoxInfo
            // 
            this.txtBoxInfo.Location = new System.Drawing.Point(76, 72);
            this.txtBoxInfo.Multiline = true;
            this.txtBoxInfo.Name = "txtBoxInfo";
            this.txtBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxInfo.Size = new System.Drawing.Size(377, 192);
            this.txtBoxInfo.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(273, 310);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBoxMessage
            // 
            this.txtBoxMessage.Location = new System.Drawing.Point(76, 270);
            this.txtBoxMessage.Name = "txtBoxMessage";
            this.txtBoxMessage.Size = new System.Drawing.Size(377, 23);
            this.txtBoxMessage.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Message";
            // 
            // listClientIP
            // 
            this.listClientIP.FormattingEnabled = true;
            this.listClientIP.ItemHeight = 15;
            this.listClientIP.Location = new System.Drawing.Point(484, 59);
            this.listClientIP.Name = "listClientIP";
            this.listClientIP.Size = new System.Drawing.Size(200, 274);
            this.listClientIP.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Client IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 353);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listClientIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBoxInfo);
            this.Controls.Add(this.txtBoxIp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP/IP Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private Label label1;
        private TextBox txtBoxIp;
        private TextBox txtBoxInfo;
        private Button btnSend;
        private TextBox txtBoxMessage;
        private Label label2;
        private ListBox listClientIP;
        private Label label3;
    }
}