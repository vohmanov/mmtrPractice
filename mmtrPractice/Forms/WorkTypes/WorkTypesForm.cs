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
    public partial class WorkTypesForm : Form
    {
        ApplicationContext db;
        public WorkTypesForm()
        {
            InitializeComponent();

            db = new ApplicationContext();
            db.WorkTypes.Load();

            dataGridView1.DataSource = db.WorkTypes.Local.ToBindingList();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Name"].HeaderText = "Название";
            dataGridView1.Columns["DefaultPrice"].HeaderText = "Начальная цена";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            WorkTypeEditForm wtForm = new WorkTypeEditForm();
            DialogResult result = wtForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            string Name = wtForm.textBoxName.Text;
            string DefaultPrice = wtForm.textBoxPrice.Text;

            if (String.IsNullOrEmpty(Name) || String.IsNullOrEmpty(DefaultPrice))
            {
                MessageBox.Show("Заполните поля \"Название\" и \"Начальная цена\"");

                return;
            }

            if (db.WorkTypes.Any(w => w.Name == Name) == true)
            {
                MessageBox.Show("Тип работы с таким названием уже существует");

                return;
            }

            WorkType workType = new WorkType();
            workType.Name = wtForm.textBoxName.Text;
            workType.DefaultPrice = int.Parse(DefaultPrice);

            db.WorkTypes.Add(workType);
            db.SaveChanges();

            MessageBox.Show("Новый тип работ добавлен");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                WorkType workType = db.WorkTypes.Find(id);

                WorkTypeEditForm wtForm = new WorkTypeEditForm();

                wtForm.buttonSubmit.Text = "Сохранить";

                wtForm.textBoxName.Text = workType.Name;
                wtForm.textBoxPrice.Text = workType.DefaultPrice.ToString();
                workType.DefaultPrice = int.Parse(wtForm.textBoxPrice.Text);

                DialogResult result = wtForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                workType.Name = wtForm.textBoxName.Text;
                workType.DefaultPrice = int.Parse(wtForm.textBoxPrice.Text);

                db.SaveChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Тип работ обновлен");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                WorkType workType = db.WorkTypes.Find(id);
                db.WorkTypes.Remove(workType);
                db.SaveChanges();

                MessageBox.Show("Тип работ удален");
            }
        }



        private void WorkTypesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
