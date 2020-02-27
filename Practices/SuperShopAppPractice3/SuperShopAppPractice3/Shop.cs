using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopAppPractice3
{
    class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }

        private List<Product> _products;

        public Shop()
        {
            _products = new List<Product>();
        }
        
        public bool AddProduct(Product product)
        {
            if(_products.Count > 0)
            {
                foreach (Product aProduct in _products)
                {
                    if(aProduct.ProductId == product.ProductId)
                    {
                        aProduct.Quantity += product.Quantity;
                        return true;
                    }
                }
            }

            _products.Add(product);
            return true;
        }

        public string GetDetails()
        {
            string message = "";

            string shopInfo = "Shop Name: " + Name + "Address: " + Address;
            string header = "Product ID \t\t Quantity";
            string productInfo = "";

            foreach(Product product in _products)
            {
                productInfo += product.ProductId + "\t\t\t " + product.Quantity + "\n";
            }

            message = shopInfo + "\n" + header + "\n" + productInfo;
            return message;
        }
    }
}
