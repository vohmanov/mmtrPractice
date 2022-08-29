using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using mmtrPractice.Models;

namespace mmtrPractice.Forms.Orders
{
    public partial class OrdersForm : Form
    {
        ApplicationContext db;
        public string currentRole;
        public int currentUserId;
        public OrdersForm(string role, int userId)
        {
            InitializeComponent();

            currentRole = role;
            currentUserId = userId;
            db = new ApplicationContext();
            db.Orders.Load();
            db.WorkTypes.Load();

            dataGridView1.DataSource = db.Orders.Local.ToBindingList();
            dataGridView1.Columns["Id"].HeaderText = "Номер заказа";
            dataGridView1.Columns["WorkType"].HeaderText = "Тип работы";
            dataGridView1.Columns["Description"].HeaderText = "Описание";
            dataGridView1.Columns["Price"].HeaderText = "Цена";
            dataGridView1.Columns["Status"].HeaderText = "Статус";
            dataGridView1.Columns["Comment"].HeaderText = "Комментарий";
            dataGridView1.Columns["PeriodExecution"].HeaderText = "Срок выполнения";
            dataGridView1.Columns["UserId"].Visible = false;
            dataGridView1.Columns["User"].Visible = false;

            if (currentRole == "MASTER")
            {
                buttonAdd.Visible = true;
                buttonEdit.Visible = true;
            }
        }

        private class WorkTypeItemData
        {
            public string Text { get; set; }
            public int Value { get; set; }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OrderEditForm oeForm = new OrderEditForm();

            oeForm.comboBoxWorkType.DisplayMember = "Text";
            oeForm.comboBoxWorkType.ValueMember = "Value";

            BindingList<WorkTypeItemData> _comboItems = new BindingList<WorkTypeItemData>();

            foreach (WorkType wt in db.WorkTypes)
            {
                _comboItems.Add(new WorkTypeItemData { Text = wt.Name, Value = wt.Id });
            }

            oeForm.comboBoxWorkType.DataSource = _comboItems;
            oeForm.comboBoxWorkType.SelectedIndex = 0;
            oeForm.comboBoxStatus.SelectedIndex = 0;
            oeForm.comboBoxStatus.Enabled = false;

            DialogResult result = oeForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Order order = new Order();
            order.WorkType = oeForm.comboBoxWorkType.Text;
            order.Price = int.Parse(oeForm.textBoxPrice.Text);
            order.UserId = currentUserId;
            order.Status = oeForm.comboBoxStatus.Text;
            order.PeriodExecution = oeForm.dateTimeDate.Text;
            order.Description = oeForm.textBoxDescription.Text;
            order.Comment = oeForm.textBoxComment.Text;

            db.Orders.Add(order);
            db.SaveChanges();

            MessageBox.Show("Заказ добавлен");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        { 
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Order order = db.Orders.Find(id);

                OrderEditForm oeForm = new OrderEditForm();

                oeForm.groupBoxOrder.Text = "Заказ №" + order.Id.ToString();
                oeForm.buttonSubmit.Text = "Сохранить";

                oeForm.comboBoxWorkType.Text = order.WorkType;
                oeForm.comboBoxWorkType.Enabled = false;
                oeForm.textBoxDescription.Text = order.Description;
                oeForm.textBoxDescription.Enabled = false;
                oeForm.dateTimeDate.Text = order.PeriodExecution;
                oeForm.dateTimeDate.Enabled = false;
                oeForm.textBoxPrice.Text = order.Price.ToString();
                oeForm.textBoxPrice.Enabled = false;
                oeForm.comboBoxStatus.Text = order.Status;
                oeForm.textBoxComment.Text = order.Comment;

                DialogResult result = oeForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                order.Status = oeForm.comboBoxStatus.Text;
                order.Comment = oeForm.textBoxComment.Text;

                db.SaveChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Информация по заказу обновлена");
            }
        }
    }
}
