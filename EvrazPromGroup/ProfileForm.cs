using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvrazPromGroup
{
    public partial class ProfileFrom : Form
    {
        private Employee employee;
        public ProfileFrom(Employee employee1 = null)
        {
            InitializeComponent();
            if (employee1 != null)
            {
                this.employee = employee1;
                textBoxFName.Text = employee.FirstName;
                textBoxSName.Text = employee.SecondName;
                textBoxId.Text = employee.Id.ToString();
                textBoxEmail.Text = employee.Email;
                maskedTextBoxBday.Text = employee.Birthday.ToString();
                maskedTextBoxPhone.Text = employee.Phone.ToString();
                textBoxPost.Text = employee.Post.ToString();
                textBoxLogin.Text = employee.Login.ToString();
                textBoxPassword.Text = employee.Password.ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool isNew = employee == null;
            if (textBoxFName.Text == null || textBoxSName.Text == null || textBoxEmail.Text == null || 
                textBoxPost.Text == null || maskedTextBoxBday.Text == null  || maskedTextBoxPhone.Text == null 
                || textBoxLogin.Text == null || textBoxPassword.Text == null)
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            else if ( isNew || (this.employee.Login != textBoxLogin.Text))
            {
                if (Repository.CheackLogin(textBoxLogin.Text))
                {
                    MessageBox.Show("Пользователь с таким login уже зарегистрирован");
                    return;
                }
            }

            textBoxLogin.ReadOnly = true;
            textBoxLogin.Enabled = false;
            textBoxLogin.BackColor = Color.Silver;
            textBoxPost.ReadOnly = true;
            textBoxPost.Enabled = false;
            textBoxPost.BackColor = Color.Silver;
            if (isNew)
            {
                employee = new Employee();
                //employee.Id = Repository.Employees.Count == 0 ? 1 : Repository.Employees.Max(t => t.Id) + 1;
            }
            else
                employee.Id = int.Parse(textBoxId.Text);

            employee.FirstName = textBoxFName.Text;
            employee.SecondName = textBoxSName.Text;
            employee.Email = textBoxEmail.Text;
            employee.Birthday = DateTime.Parse(maskedTextBoxBday.Text);
            employee.Phone = maskedTextBoxPhone.Text;
            employee.Post = textBoxPost.Text;
            employee.Login = textBoxLogin.Text;
            employee.Password = textBoxPassword.Text;
            if (isNew)
            {
                Repository.Add(employee);
                DialogResult dialog = MessageBox.Show("The employee is registered", "Res", MessageBoxButtons.OK);
            }
            else
            {
                Repository.Update(employee);
                DialogResult dialog = MessageBox.Show("Personal data updated", "Res", MessageBoxButtons.OK);
            }
            Close();
            //DialogResult dialog = MessageBox.Show("Personal data updated", "Res", MessageBoxButtons.OK);
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.ShowDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAvatar.ImageLocation = openFileDialog.FileName;
            }
            else
                return;
        }
        public void OpenForNewEmpl()
        {
            textBoxLogin.ReadOnly = false;
            textBoxLogin.Enabled = true;
            textBoxLogin.BackColor = Color.White;
            textBoxPost.ReadOnly = false;
            textBoxPost.Enabled = true;
            textBoxPost.BackColor = Color.White;
        }
    }
}
