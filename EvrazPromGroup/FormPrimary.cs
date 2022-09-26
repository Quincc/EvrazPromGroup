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
    public partial class FormPrimary : Form
    {
        private Employee employee;
        public FormPrimary(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            //Repository.FindEmployee(employee.Login, employee.Password)
            OpenChildForm(new ProfileFrom(Repository.FindEmployee(employee.Login, employee.Password)), sender);
            labelChildForm.Text = "Profile";
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrdersForm(), sender);
            labelChildForm.Text = "Orders";
        }
        private void OpenChildForm(Form childForm, object obj)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesk.Controls.Add(childForm);
            this.panelDesk.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelChildForm.Text = childForm.Text;

        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new About(), sender);
            labelChildForm.Text = "About";
        }

        private void buttonaEmployees_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeesForm(), sender);
            labelChildForm.Text = "Employees";
        }

        private void FormPrimary_Load(object sender, EventArgs e)
        {

        }
    }
}
