using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Form1.Objects;

namespace SQL_Form1.dbAccess
{
    class OrderProductDBAccess
    {
        private Database db;

        public OrderProductDBAccess(Database _db)
        {
            db = _db;
        }

        public void InsertOrderProduct(OrderProduct op)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $"INSERT INTO OrderProduct VALUES ('{op.OrderCode}','{op.ProductCode}','{op.Qty}')";
            db.Cmd.ExecuteNonQuery();
        }
    }
}
