using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFitness
{
    public class Shop
    {
       public double ProductPrice;
       public string ProductName, ProductCode; 
       public int Quantity;
       public bool IsAvailable;
       public Product MyProduct;

       public Shop(double productPrice, string productName, string productCode, int quantity, bool isAvailable, Product myProduct)
        {
            this.ProductPrice = productPrice;
            this.ProductName = productName;
            this.ProductCode = productCode;
            this.Quantity = quantity;
            this.IsAvailable = isAvailable;
            this.MyProduct = myProduct;
        }
       public void AddProduct(Product myProduct)
       {

       }
       public void RemoveProduct(Product myProduct)
       {

       }
       public void UpdateProduct(Product myProduct)
       {

       }
    }
}
