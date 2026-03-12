using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Form1.Objects;
using SQL_Form1.dbAccess;

namespace SQL_Form1.dbAccess
{
    class OrderDBAccess
    {
        private Database db;

        public OrderDBAccess(Database _db)
        {
            db = _db;
        }

        public OrderDBAccess()
        {

        }
        public void InsertOrder(Order ord)
        {
            string sqlCmd = $"Insert Into dbo.[Order](OrderDate, Employee) Values('{ord.OrderDate1}','{ord.Employee1}')";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Cmd.ExecuteNonQuery();

        }

        public int GetOrderCode()
        {
            int no = 0;
            while (db.Rdr.Read())
            {
                no = db.Rdr.GetInt32(0);
            }
            db.Rdr.Close();
            return no;
        }

        public void PreviousOrder()
        {
            string sqlCmd = $"Select MAX(OrderCode) From dbo.[Order]";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }
    }
}
