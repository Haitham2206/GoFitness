using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFitness
{
    public class Product
    {
        public double ProductPrice;
        public string ProductCode, ProductName;
        public int  Quantity;
        public bool IsAvailable;
        public Product(double productPrice, string productName, string productCode, int quantity, bool isAvailable)
        {
            this.ProductPrice = productPrice;
            this.ProductName = productName;
            this.ProductCode = productCode;
            this.Quantity = quantity;
            this.IsAvailable = isAvailable;

        }
        //proprty
        public double ProductPrice_prop{ get { return ProductPrice; } set { ProductPrice = value; } }
        public string ProductName_prop { get { return ProductName; } set { ProductName = value; } }
        public string ProductCode_prop { get { return ProductCode; } set { ProductCode = value; } }
        public int Quantity_prop { get { return Quantity; } set { Quantity = value; } }
        //function
        public bool Product_IsAvalable(int quantity,int productCode)
        {
            return true;
        }
       
    }
}
