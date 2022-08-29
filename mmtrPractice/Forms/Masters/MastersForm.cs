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


namespace mmtrPractice.Forms.Masters
{
    public partial class MastersForm : Form
    {
        ApplicationContext db;
        public MastersForm()
        {
            InitializeComponent();

            db = new ApplicationContext();
            db.Users.Load();

            updateDataGridView();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Role"].Visible = false;
            dataGridView1.Columns["Login"].HeaderText = "Логин";
            dataGridView1.Columns["Password"].HeaderText = "Пароль";
        }

        private void updateDataGridView()
        {
            var users = db.Users.Where(u => u.Role == "MASTER");
            dataGridView1.DataSource = new BindingList<User>(users.ToList());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string Login = textBoxLogin.Text;
            string Password = textBoxPassword.Text;

            if (String.IsNullOrEmpty(Login) || String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Заполните поля \"Логин\" и \"Пароль\"");

                return;
            }

            if (db.Users.Any(u => u.Login == Login) == true)
            {
                MessageBox.Show("Мастер с таким логином уже существует");

                return;
            }

            User user = new User();
            user.Login = Login;
            user.Password = Password;
            user.Role = "MASTER";

            db.Users.Add(user);
            db.SaveChanges();
            updateDataGridView();
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";

            MessageBox.Show("Мастер добавлен");
        }
    }
}
