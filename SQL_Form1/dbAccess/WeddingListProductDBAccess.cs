using System;
using SQL_Form1.Objects;
using SQL_Form1.dbAccess;
using SQL_Form1.GUI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Form1.dbAccess
{
    class WeddingListProductDBAccess
    {
        private Database db;

        public WeddingListProductDBAccess(Database _db)
        {
            db = _db;
        }

        public WeddingListProduct GetWeddingListProductFromReader()
        {
            WeddingListProduct weddingListProduct = new WeddingListProduct();
            weddingListProduct.WeddingListNo1 = db.Rdr.GetInt32(0);
            weddingListProduct.Qty1 = db.Rdr.GetInt32(1);
            weddingListProduct.ProductCode1 = db.Rdr.GetString(2);
            weddingListProduct.ConfirmedPurchase1 = db.Rdr.GetString(3);
            weddingListProduct.CustomerName1 = db.Rdr.GetString(4);
            weddingListProduct.PurchasedDate1 = db.Rdr.GetDateTime(5);

            return weddingListProduct;
        }

        public List<WeddingListProduct> GetWLProductList()
        {
            List<WeddingListProduct> ListOfProducts = new List<WeddingListProduct>();
            while (db.Rdr.Read())
            {
                ListOfProducts.Add(GetWeddingListProductFromReader());
            }
            db.Rdr.Close();
            return ListOfProducts;
        }

        public List<WeddingListProduct> GetWLProductQTYList()
        {
            List<WeddingListProduct> ListOfProducts = new List<WeddingListProduct>();
            while (db.Rdr.Read())
            {
                ListOfProducts.Add(GetWeddingListProductQTYFromReader());
            }
            db.Rdr.Close();
            return ListOfProducts;
        }

        public WeddingListProduct GetWeddingListProductQTYFromReader()
        {
            WeddingListProduct weddingListProduct = new WeddingListProduct();
            weddingListProduct.Qty1 = db.Rdr.GetInt32(0);

            return weddingListProduct;
        }
        public void AddWLProduct(int weddingListNo, int productCode, int qty)
        {
            string sql = $"INSERT INTO WeddingListProduct(WeddingListNo, ProductCode, Qty) VALUES ({weddingListNo}, {productCode}, {qty})";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sql;
            db.Cmd.ExecuteNonQuery();
        }
        //public void GetWLProductsDetails(int weddingListNo)
        //{
        //    string sqlCmd = $"SELECT Qty FROM WeddingListProduct WLP inner join Product p on p.ProductCode = wlp.ProductCode where WeddingListNo = {weddingListNo}";
        //    db.Cmd = db.Conn.CreateCommand();
        //    db.Cmd.CommandText = sqlCmd;
        //    db.Rdr = db.Cmd.ExecuteReader();
        //}

        public void DeleteWLProduct(int weddingListNo, int productCode)
        {
            string sqlCmd = $"Delete From WeddingListProduct Where weddingListNo = {weddingListNo} AND productCode = {productCode}";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Cmd.ExecuteNonQuery();
        }
    }
}

