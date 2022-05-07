namespace SimpleHTTPServer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartServerBtn = new System.Windows.Forms.Button();
            this.StopServerBtn = new System.Windows.Forms.Button();
            this.PortTxtBox = new System.Windows.Forms.TextBox();
            this.ServerLogsTxtBox = new System.Windows.Forms.TextBox();
            this.ServerPortLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartServerBtn
            // 
            this.StartServerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartServerBtn.Location = new System.Drawing.Point(22, 65);
            this.StartServerBtn.Name = "StartServerBtn";
            this.StartServerBtn.Size = new System.Drawing.Size(101, 23);
            this.StartServerBtn.TabIndex = 0;
            this.StartServerBtn.Text = "Start Server";
            this.StartServerBtn.UseVisualStyleBackColor = true;
            this.StartServerBtn.Click += new System.EventHandler(this.StartServerBtn_Click);
            // 
            // StopServerBtn
            // 
            this.StopServerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StopServerBtn.Location = new System.Drawing.Point(22, 103);
            this.StopServerBtn.Name = "StopServerBtn";
            this.StopServerBtn.Size = new System.Drawing.Size(101, 23);
            this.StopServerBtn.TabIndex = 1;
            this.StopServerBtn.Text = "Stop Server";
            this.StopServerBtn.UseVisualStyleBackColor = true;
            this.StopServerBtn.Click += new System.EventHandler(this.StopServerBtn_Click);
            // 
            // PortTxtBox
            // 
            this.PortTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PortTxtBox.Location = new System.Drawing.Point(26, 175);
            this.PortTxtBox.Name = "PortTxtBox";
            this.PortTxtBox.Size = new System.Drawing.Size(97, 22);
            this.PortTxtBox.TabIndex = 2;
            // 
            // ServerLogsTxtBox
            // 
            this.ServerLogsTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ServerLogsTxtBox.Location = new System.Drawing.Point(189, 42);
            this.ServerLogsTxtBox.Multiline = true;
            this.ServerLogsTxtBox.Name = "ServerLogsTxtBox";
            this.ServerLogsTxtBox.Size = new System.Drawing.Size(549, 360);
            this.ServerLogsTxtBox.TabIndex = 3;
            // 
            // ServerPortLbl
            // 
            this.ServerPortLbl.AutoSize = true;
            this.ServerPortLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ServerPortLbl.Location = new System.Drawing.Point(23, 159);
            this.ServerPortLbl.Name = "ServerPortLbl";
            this.ServerPortLbl.Size = new System.Drawing.Size(74, 16);
            this.ServerPortLbl.TabIndex = 4;
            this.ServerPortLbl.Text = "Server Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(186, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server logs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 414);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServerPortLbl);
            this.Controls.Add(this.ServerLogsTxtBox);
            this.Controls.Add(this.PortTxtBox);
            this.Controls.Add(this.StopServerBtn);
            this.Controls.Add(this.StartServerBtn);
            this.Name = "Form1";
            this.Text = "Simple HTTP Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartServerBtn;
        private System.Windows.Forms.Button StopServerBtn;
        private System.Windows.Forms.TextBox PortTxtBox;
        private System.Windows.Forms.TextBox ServerLogsTxtBox;
        private System.Windows.Forms.Label ServerPortLbl;
        private System.Windows.Forms.Label label2;
    }
}

