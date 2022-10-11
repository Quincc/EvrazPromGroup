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
    public partial class ProductForm : Form
    {
        private Product product;
        public ProductForm(Product product = null)
        {
            InitializeComponent();
            comboBoxStatus.DataSource = Enum.GetValues(typeof(Status));
            if (product != null)
            {
                this.product = product;
                textBoxCodebar.Text = product.Codebar;
                textBoxCustomer.Text = product.Сustomer;
                textBoxPrice.Text = product.Price.ToString();
                numericUpDownQuantity.Value = product.Quantity;
                comboBoxStatus.SelectedItem = product.Status;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool isNew = product == null;
            if (product == null)
            {
                product = new Product();
            }
            product.Codebar = textBoxCodebar.Text;
            product.Сustomer = textBoxCustomer.Text;
            product.Price = decimal.Parse(textBoxPrice.Text);
            product.Quantity = int.Parse(numericUpDownQuantity.Value.ToString());
            product.Status = (Status)comboBoxStatus.SelectedItem;
            //product.Id = int.Parse(textBoxId.Text);
            if (isNew)
                Repository.Add(product);
            else
                Repository.Update(product);

            DialogResult = DialogResult.OK;
        }
    }
}
