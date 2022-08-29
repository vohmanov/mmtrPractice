namespace mmtrPractice.Forms.Masters
{
    partial class MastersForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxAddMaster = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxAddMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(324, 194);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // groupBoxAddMaster
            // 
            this.groupBoxAddMaster.Controls.Add(this.label2);
            this.groupBoxAddMaster.Controls.Add(this.label1);
            this.groupBoxAddMaster.Controls.Add(this.textBoxPassword);
            this.groupBoxAddMaster.Controls.Add(this.buttonAdd);
            this.groupBoxAddMaster.Controls.Add(this.textBox2);
            this.groupBoxAddMaster.Controls.Add(this.textBoxLogin);
            this.groupBoxAddMaster.Location = new System.Drawing.Point(12, 212);
            this.groupBoxAddMaster.Name = "groupBoxAddMaster";
            this.groupBoxAddMaster.Size = new System.Drawing.Size(324, 73);
            this.groupBoxAddMaster.TabIndex = 1;
            this.groupBoxAddMaster.TabStop = false;
            this.groupBoxAddMaster.Text = "Добавить нового мастера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(119, 44);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PlaceholderText = "Введите пароль";
            this.textBoxPassword.Size = new System.Drawing.Size(107, 23);
            this.textBoxPassword.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(243, 44);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(-165, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 23);
            this.textBox2.TabIndex = 0;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(6, 44);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.PlaceholderText = "Введите логин";
            this.textBoxLogin.Size = new System.Drawing.Size(107, 23);
            this.textBoxLogin.TabIndex = 0;
            // 
            // MastersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 297);
            this.Controls.Add(this.groupBoxAddMaster);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MastersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MastersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxAddMaster.ResumeLayout(false);
            this.groupBoxAddMaster.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxAddMaster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox Password;
    }
}