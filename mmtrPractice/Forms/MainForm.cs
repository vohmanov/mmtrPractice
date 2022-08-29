using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mmtrPractice.Forms.Orders;

namespace mmtrPractice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonClientWindow_Click(object sender, EventArgs e)
        {
            ClientForm form2 = new ClientForm();
            form2.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.ShowDialog();
        }
    }
}
