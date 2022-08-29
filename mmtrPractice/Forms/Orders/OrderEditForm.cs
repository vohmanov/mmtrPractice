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
    public partial class OrderEditForm : Form
    {
        ApplicationContext db;
        public OrderEditForm()
        {
            InitializeComponent();

            db = new ApplicationContext();
            db.WorkTypes.Load();
        }

        private void comboBoxWorkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            WorkType workType = db.WorkTypes.Find(comboBoxWorkType.SelectedValue);
            textBoxPrice.Text = workType.DefaultPrice.ToString();
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
