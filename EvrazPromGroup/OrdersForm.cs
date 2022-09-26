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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        //private void FormGeneral_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'evrazUsersDataSet1.Users' table. You can move, or remove it, as needed.
        //    this.usersTableAdapter1.Fill(this.evrazUsersDataSet1.Users);
        //    // TODO: This line of code loads data into the 'evrazUsersDataSet.Users' table. You can move, or remove it, as needed.
        //    this.usersTableAdapter.Fill(this.evrazUsersDataSet.Users);

        //}
        private void LoadData()
        {
            dataGridViewUsers.DataSource = null;
            if (Repository.Products.Count > 0)
                dataGridViewUsers.DataSource = Repository.Products;
        }

        private void FormGeneral_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'evrazUsersDataSet3.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter3.Fill(this.evrazUsersDataSet3.Users);
            // TODO: This line of code loads data into the 'evrazUsersDataSet2.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter2.Fill(this.evrazUsersDataSet2.Users);
            LoadData();
        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            if(dataGridViewUsers.SelectedRows.Count == 1)
            {
                Product product = (Product)dataGridViewUsers.SelectedRows[0].DataBoundItem;
                ProductForm form = new ProductForm(product);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 1)
            {
                Product product = ( Product)dataGridViewUsers.SelectedRows[0].DataBoundItem;
                DialogResult a = MessageBox.Show("Вы действительно хотите удалить задачу?", "OK", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {
                    Repository.Remove(product);
                    LoadData();
                }
            }
        }
    }
}
