using SQL_Form1.Objects;
using SQL_Form1.dbAccess;
using SQL_Form1.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Form1.dbAccess
{
    class ProductDBAccess
    {
        private Database db;
        public ProductDBAccess(Database _db)
        {
            db = _db;
        }

        public Product GetProductsFromReader()
        {
            Product products = new Product();
            products.ProductCode = db.Rdr.GetInt32(0);
            products.ProductName = db.Rdr.GetString(1);
            products.ProductDescription = db.Rdr.GetString(2);
            products.ProductManufacturer = db.Rdr.GetString(3);
            products.ProductCategory = db.Rdr.GetString(4);
            products.ProductPrice = db.Rdr.GetDecimal(5);

            return products;
        }

        public Product GetManageProductsFromReader()
        {
            Product products = new Product();
            products.ProductCode = db.Rdr.GetInt32(0);
            products.ProductName = db.Rdr.GetString(1);
            products.ProductDescription = db.Rdr.GetString(2);
            products.ProductCategory = db.Rdr.GetString(3);
            products.ProductPrice = db.Rdr.GetDecimal(4);

            return products;
        }
        public Product GetProductPriceFromReader()
        {
            Product products = new Product();
            products.ProductPrice = db.Rdr.GetDecimal(0);

            return products;
        }
        public List<Product> GetProductList()
        {
            List<Product> ListOfProducts = new List<Product>();
            while (db.Rdr.Read())
            {
                ListOfProducts.Add(GetProductsFromReader());
            }
            db.Rdr.Close();
            return ListOfProducts;
        }

        public List<Product> GetManageProductList()
        {
            List<Product> ListOfProducts = new List<Product>();
            while (db.Rdr.Read())
            {
                ListOfProducts.Add(GetManageProductsFromReader());
            }
            db.Rdr.Close();
            return ListOfProducts;
        }

        public DataTable ProductsDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Load(db.Rdr);
            GetProducts();
            db.Rdr.Close();
            return dataTable;
        }
        public Product GetProductObject()
        {
            Product product = new Product();
            while (db.Rdr.Read())
            {
                product = GetProductPriceFromReader();
            }
            db.Rdr.Close();
            return product;
        }

        
        public void GetProducts()
        {
            Product products = new Product();
            WeddingListProduct weddingListProduct = new WeddingListProduct();

            string sqlCmd = $"SELECT ProductName = '{products.ProductName}', ProductDescription = '{products.ProductDescription}', ProductCategory = '{products.ProductCategory}', ProductPrice = '{products.ProductPrice}', Qty = '{weddingListProduct.Qty1}', ConfirmedPurchase = '{weddingListProduct.ConfirmedPurchase1}', CustomerName = '{weddingListProduct.ConfirmedPurchase1}' FROM Product";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }
        public void GetProductsDetails(int weddingListNo)
        {
            string sqlCmd = $"SELECT p.ProductCode, ProductName, ProductDescription, ProductCategory, ProductPrice FROM Weddinglistproduct wlp inner join Product p on wlp.ProductCode = p.ProductCode where WeddingListNo = {weddingListNo}";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }
        public void FindPDetails(string name)
        {
            string sqlCmd = $"SELECT p.ProductCode, ProductName, ProductDescription, ProductCategory, ProductPrice, Qty, ConfirmedPurchase, CustomerName FROM Weddinglistproduct wlp inner join Product p on wlp.ProductCode = p.ProductCode inner Join WeddingList WL on wlp.WeddingListNo = WL.WeddingListNo where CONCAT(ClientForename, ' ', ClientSurname) = '{name}'";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }

        public void GetAllProductsDetails()
        {
            string sqlCmd = $"SELECT * From Product";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }
        public void UpdateDGVColumns()
        {
            Product p = new Product();
            string sqlCmd = $"UPDATE Product SET ProductDescription = '{p.ProductDescription}', ProductCategory = '{p.ProductCategory}', ProductPrice = '{p.ProductPrice}' WHERE ProductName = '{p.ProductName}'";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }

        public void LineTotal(int productCode)
        {
            string sqlCmd = $"SELECT ProductPrice From Product WHERE ProductCode = '{productCode}'";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }

        
    }
}
