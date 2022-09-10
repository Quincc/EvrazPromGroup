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
            if(Cheack_User(textBox_Login.Text, textBoxPassword.Text))
            {
                FormGeneral form = new FormGeneral();
                form.ShowDialog();
            }
        }
        private bool Cheack_User(string login, string password)
        {
            using (StreamReader reader = new StreamReader("Users"))
            {
                string text = reader.ReadToEnd();
                for (int i = 0; i < text.Length; i++)
                {
                    if (text. == $"{login} {password}")
                    {

                    }
                }    
            }
            return false;
        }
    }
}
