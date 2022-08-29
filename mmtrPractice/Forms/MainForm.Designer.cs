namespace mmtrPractice
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClientWindow = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Компьютерный сервис";
            // 
            // buttonClientWindow
            // 
            this.buttonClientWindow.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClientWindow.Location = new System.Drawing.Point(126, 106);
            this.buttonClientWindow.Name = "buttonClientWindow";
            this.buttonClientWindow.Size = new System.Drawing.Size(131, 35);
            this.buttonClientWindow.TabIndex = 1;
            this.buttonClientWindow.Text = "Клиент";
            this.buttonClientWindow.UseVisualStyleBackColor = true;
            this.buttonClientWindow.Click += new System.EventHandler(this.buttonClientWindow_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(126, 147);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(131, 35);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Сотрудник";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 296);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonClientWindow);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClientWindow;
        private System.Windows.Forms.Button buttonLogin;
    }
}

