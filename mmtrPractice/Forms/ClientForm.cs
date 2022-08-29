using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using mmtrPractice.Models;
using System.Linq;

namespace mmtrPractice
{
    public partial class ClientForm : Form
    {
        ApplicationContext db;
        public ClientForm()
        {
            InitializeComponent();

            db = new ApplicationContext();
            db.Orders.Load();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxOrderNum.Text))
            {
                MessageBox.Show("Укажите номер заказа");

                return;
            }

            int orderNum = int.Parse(textBoxOrderNum.Text);

            if (db.Orders.Any(o => o.Id == orderNum) == true)
            {
                Order order = db.Orders.Find(orderNum);

                MessageBox.Show("Статус заказа: " + order.Status + "\r\nКомментарий мастера: " + order.Comment);
            }
            else
            {
                MessageBox.Show("Заказа с таким номером не существует");
            }
        }

        private void textBoxOrderNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
