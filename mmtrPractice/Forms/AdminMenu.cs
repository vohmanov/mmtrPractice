using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using mmtrPractice.Forms.Masters;
using mmtrPractice.Forms.Orders;

namespace mmtrPractice.Forms
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void buttonOrdersList_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm("ADMIN", 1);
            form.ShowDialog();
        }

        private void buttonWorkTypesList_Click(object sender, EventArgs e)
        {
            WorkTypesForm form = new WorkTypesForm();
            form.ShowDialog();
        }

        private void buttonMastersList_Click(object sender, EventArgs e)
        {
            MastersForm form = new MastersForm();
            form.ShowDialog();
        }
    }
}
