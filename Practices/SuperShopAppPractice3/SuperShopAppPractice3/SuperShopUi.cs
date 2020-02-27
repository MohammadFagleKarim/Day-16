using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopAppPractice3
{
    public partial class SuperShopUi : Form
    {
        public SuperShopUi()
        {
            InitializeComponent();
        }

        private Shop _shop;

        private void ShopSaveButton_Click(object sender, EventArgs e)
        {
            _shop = new Shop();

            _shop.Name = nameTextBox.Text;
            _shop.Address = addressTextBox.Text;

            nameTextBox.Clear();
            addressTextBox.Clear();

            MessageBox.Show("Successfully Saved.");
        }

        private void ProductSaveButton_Click(object sender, EventArgs e)
        {
            if(_shop == null)
            {
                MessageBox.Show("Shop is not created, please create a shop!"); 
            }

            Product product = new Product();

            product.ProductId = itemTextBox.Text;
            product.Quantity = Convert.ToInt32(quantityTextBox.Text);

            bool isAdded = _shop.AddProduct(product);

            if(isAdded)
            {
                itemTextBox.Clear();
                quantityTextBox.Clear();
                MessageBox.Show("Successfully Added");
            }
            else
            {
                MessageBox.Show("Not Added");
            }
        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            string message = _shop.GetDetails();
            MessageBox.Show(message);
        }
    }
}
