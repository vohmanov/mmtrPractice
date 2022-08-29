namespace mmtrPractice.Forms.Orders
{
    partial class OrderEditForm
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
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dateTimeDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxWorkType = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.Controls.Add(this.buttonSubmit);
            this.groupBoxOrder.Controls.Add(this.buttonCancel);
            this.groupBoxOrder.Controls.Add(this.textBoxComment);
            this.groupBoxOrder.Controls.Add(this.comboBoxStatus);
            this.groupBoxOrder.Controls.Add(this.dateTimeDate);
            this.groupBoxOrder.Controls.Add(this.textBoxPrice);
            this.groupBoxOrder.Controls.Add(this.comboBoxWorkType);
            this.groupBoxOrder.Controls.Add(this.textBoxDescription);
            this.groupBoxOrder.Controls.Add(this.label6);
            this.groupBoxOrder.Controls.Add(this.label5);
            this.groupBoxOrder.Controls.Add(this.label4);
            this.groupBoxOrder.Controls.Add(this.label3);
            this.groupBoxOrder.Controls.Add(this.label2);
            this.groupBoxOrder.Controls.Add(this.label1);
            this.groupBoxOrder.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(329, 361);
            this.groupBoxOrder.TabIndex = 0;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "Новый заказ";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSubmit.Location = new System.Drawing.Point(231, 312);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Добавить";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(150, 312);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(154, 237);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(152, 23);
            this.textBoxComment.TabIndex = 1;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Принят",
            "В работе",
            "Завершен"});
            this.comboBoxStatus.Location = new System.Drawing.Point(154, 201);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(152, 23);
            this.comboBoxStatus.TabIndex = 2;
            // 
            // dateTimeDate
            // 
            this.dateTimeDate.Location = new System.Drawing.Point(154, 157);
            this.dateTimeDate.Name = "dateTimeDate";
            this.dateTimeDate.Size = new System.Drawing.Size(152, 23);
            this.dateTimeDate.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(154, 120);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(152, 23);
            this.textBoxPrice.TabIndex = 1;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // comboBoxWorkType
            // 
            this.comboBoxWorkType.FormattingEnabled = true;
            this.comboBoxWorkType.Location = new System.Drawing.Point(154, 37);
            this.comboBoxWorkType.Name = "comboBoxWorkType";
            this.comboBoxWorkType.Size = new System.Drawing.Size(152, 23);
            this.comboBoxWorkType.TabIndex = 2;
            this.comboBoxWorkType.SelectedIndexChanged += new System.EventHandler(this.comboBoxWorkType_SelectedIndexChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(154, 81);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(152, 23);
            this.textBoxDescription.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Комментарий";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Статус";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Срок выполнения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип работы";
            // 
            // OrderEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 385);
            this.Controls.Add(this.groupBoxOrder);
            this.Name = "OrderEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderEditForm";
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TextBox textBoxComment;
        protected internal System.Windows.Forms.ComboBox comboBoxStatus;
        protected internal System.Windows.Forms.DateTimePicker dateTimeDate;
        protected internal System.Windows.Forms.TextBox textBoxPrice;
        protected internal System.Windows.Forms.ComboBox comboBoxWorkType;
        protected internal System.Windows.Forms.TextBox textBoxDescription;
        protected internal System.Windows.Forms.Button buttonSubmit;
        protected internal System.Windows.Forms.Button buttonCancel;
        protected internal System.Windows.Forms.GroupBox groupBoxOrder;
    }
}