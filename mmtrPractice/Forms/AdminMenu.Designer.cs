namespace mmtrPractice.Forms
{
    partial class AdminMenu
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
            this.buttonMastersList = new System.Windows.Forms.Button();
            this.buttonOrdersList = new System.Windows.Forms.Button();
            this.buttonWorkTypesList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMastersList
            // 
            this.buttonMastersList.Location = new System.Drawing.Point(54, 52);
            this.buttonMastersList.Name = "buttonMastersList";
            this.buttonMastersList.Size = new System.Drawing.Size(139, 38);
            this.buttonMastersList.TabIndex = 0;
            this.buttonMastersList.Text = "Список мастеров";
            this.buttonMastersList.UseVisualStyleBackColor = true;
            this.buttonMastersList.Click += new System.EventHandler(this.buttonMastersList_Click);
            // 
            // buttonOrdersList
            // 
            this.buttonOrdersList.Location = new System.Drawing.Point(54, 96);
            this.buttonOrdersList.Name = "buttonOrdersList";
            this.buttonOrdersList.Size = new System.Drawing.Size(139, 38);
            this.buttonOrdersList.TabIndex = 0;
            this.buttonOrdersList.Text = "Список заказов";
            this.buttonOrdersList.UseVisualStyleBackColor = true;
            this.buttonOrdersList.Click += new System.EventHandler(this.buttonOrdersList_Click);
            // 
            // buttonWorkTypesList
            // 
            this.buttonWorkTypesList.Location = new System.Drawing.Point(54, 140);
            this.buttonWorkTypesList.Name = "buttonWorkTypesList";
            this.buttonWorkTypesList.Size = new System.Drawing.Size(139, 38);
            this.buttonWorkTypesList.TabIndex = 0;
            this.buttonWorkTypesList.Text = "Список типов работ";
            this.buttonWorkTypesList.UseVisualStyleBackColor = true;
            this.buttonWorkTypesList.Click += new System.EventHandler(this.buttonWorkTypesList_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 234);
            this.Controls.Add(this.buttonWorkTypesList);
            this.Controls.Add(this.buttonOrdersList);
            this.Controls.Add(this.buttonMastersList);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMastersList;
        private System.Windows.Forms.Button buttonOrdersList;
        private System.Windows.Forms.Button buttonWorkTypesList;
    }
}