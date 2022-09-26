using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvrazPromGroup
{
    public partial class Authorization_Form : Form
    {
        public Authorization_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            //if(Cheack_User(textBox_Login.Text, textBoxPassword.Text))
            //{
            //    this.Hide();
            //    FormPrimary form = new FormPrimary();
            //    form.Closed += (s, args) => this.Close();
            //    form.ShowDialog();
            //}
            if(Cheack_User1(textBox_Login.Text, textBoxPassword.Text) != null)
            {
                this.Hide();
                FormPrimary form = new FormPrimary(Cheack_User1(textBox_Login.Text, textBoxPassword.Text));
                form.Closed += (s, args) => this.Close();
                form.ShowDialog();
            }
        }
        private bool Cheack_User(string login, string password)
        {
            using (StreamReader reader = new StreamReader("Users.txt"))
            {
                string us = reader.ReadToEnd();
                string[] text = us.Split(new string[] {"\r\n", "\r", "\n"}, StringSplitOptions.None);
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == $"{login} {password}")
                    {
                        return true;
                    }
                }    
            }
            return false;
        }
        private Employee Cheack_User1(string login, string password)
        {
            if (Repository.FindEmployee(login, password) != null)
                return Repository.FindEmployee(login, password);
            return null;
        }
        private void textBox_Login_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text == "Login")
                textBox_Login.Text = "";
            
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "***")
                textBoxPassword.Text = "";
        }

        private void Authorization_Form_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text == "" && textBoxPassword.Text == "")
            {
                textBox_Login.Text = "Login";
                textBoxPassword.Text = "***";
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
