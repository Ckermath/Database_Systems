using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Form1.dbAccess;
using SQL_Form1.Objects;

namespace SQL_Form1.dbAccess
{
    class WeddingListOrderDBAccess
    {
        private Database db;

        public WeddingListOrderDBAccess(Database _db)
        {
            db = _db;
        }

        public void InsertWLOrder(WeddingListOrder wedListOrd)
        {
            string sqlCmd = $"Insert Into OrderProduct Values({wedListOrd.OrderCode}, {wedListOrd.WeddingListNo},'{wedListOrd.CustomerName}')";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Cmd.ExecuteNonQuery();

        }
    }
}
