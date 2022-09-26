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
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'evrazUsersDataSet.Employes' table. You can move, or remove it, as needed.
            this.employesTableAdapter.Fill(this.evrazUsersDataSet.Employes);
            // TODO: This line of code loads data into the 'evrazUsersDataSet.Employes' table. You can move, or remove it, as needed.
            this.employesTableAdapter.Fill(this.evrazUsersDataSet.Employes);

        }
        private void LoadData()
        {
            dataGridViewEmployees.DataSource = null;
            if (Repository.Employees.Count > 0)
                dataGridViewEmployees.DataSource = Repository.Employees;
        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            ProfileFrom profileFrom = new ProfileFrom();
            profileFrom.OpenForNewEmpl();
            if (profileFrom.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count == 1)
            {
                var res = dataGridViewEmployees.SelectedCells;
                Employee employee = new Employee();
                employee.Id = int.Parse(res[0].Value.ToString());
                employee.FirstName = res[1].Value.ToString();
                employee.SecondName = res[2].Value.ToString();
                employee.Birthday = DateTime.Parse(res[3].Value.ToString());
                employee.Email = res[4].Value.ToString();
                employee.Phone = res[5].Value.ToString();
                employee.Post = res[6].Value.ToString();
                employee.Login = res[7].Value.ToString();
                employee.Password = res[8].Value.ToString();
               // Employee employee = (Employee)dataGridViewEmployees.SelectedRows[0].DataBoundItem;
                ProfileFrom form = new ProfileFrom(employee);
                form.OpenForNewEmpl();
                if (form.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count == 1)
            {
                //Employee employee = (Employee)dataGridViewEmployees.SelectedRows[0].DataBoundItem;
                var res = dataGridViewEmployees.SelectedCells;
                Employee employee = new Employee();
                employee.Id = int.Parse(res[0].Value.ToString());
                employee.FirstName = res[1].Value.ToString();
                employee.SecondName = res[2].Value.ToString();
                employee.Birthday = DateTime.Parse(res[3].Value.ToString());
                employee.Email = res[4].Value.ToString();
                employee.Phone = res[5].Value.ToString();
                employee.Post = res[6].Value.ToString();
                employee.Login = res[7].Value.ToString();
                employee.Password = res[8].Value.ToString();
                DialogResult a = MessageBox.Show("Вы действительно хотите удалить задачу?", "OK", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {
                    Repository.Remove(employee);
                    LoadData();
                }
            }
        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
