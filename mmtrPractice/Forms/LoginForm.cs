using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using mmtrPractice.Models;
using mmtrPractice.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using mmtrPractice.Forms.Orders;

namespace mmtrPractice
{
    public partial class LoginForm : Form
    {
        ApplicationContext db;
        public LoginForm()
        {
            InitializeComponent();

            textBoxPassword.PasswordChar = '\u25CF';

            db = new ApplicationContext();
            db.Users.Load();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string Login = textBoxLogin.Text;
            string Password = textBoxPassword.Text;

            if (String.IsNullOrEmpty(Login) || String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Введите логин и пароль");

                return;
            }

            if (db.Users.Any(u => u.Login == Login) == true)
            {
                foreach (var user in db.Users)
                {
                    if (user.Login == Login)
                    {
                        if (user.Password == Password)
                        {
                            var role = user.Role;
                            if (user.Role == "ADMIN")
                            {
                                this.Visible = false;
                                AdminMenu form = new AdminMenu();
                                form.ShowDialog();
                                this.Close();
                            }
                            if (user.Role == "MASTER")
                            {
                                this.Visible = false;
                                OrdersForm form = new OrdersForm(user.Role, user.Id);
                                form.ShowDialog();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Вы ввели неправильный пароль");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует");
            }
        }
    }
}
