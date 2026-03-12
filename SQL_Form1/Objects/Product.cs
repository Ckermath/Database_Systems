using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Form1.Objects
{
    class Product
    {
        int productCode;
        string productName, productCategory, productDescription, productManufacturer;
        Decimal productPrice;

        public int ProductCode { get => productCode; set => productCode = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string ProductCategory { get => productCategory; set => productCategory = value; }
        public string ProductDescription { get => productDescription; set => productDescription = value; }
        public string ProductManufacturer { get => productManufacturer; set => productManufacturer = value; }
        public decimal ProductPrice { get => productPrice; set => productPrice = value; }

        public Product(int productCode, DateTime purchasedDate, decimal productPrice, string productDescription, string productCategory, string productManufacturer)
        {
            this.productPrice = productPrice;
            this.productCode = productCode;
            this.productDescription = productDescription;
            this.productCategory = productCategory;
            this.productPrice = productPrice;
            this.productManufacturer = productManufacturer;
        }
        public Product()
        {

        }
    }
}
