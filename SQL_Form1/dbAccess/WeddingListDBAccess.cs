using SQL_Form1.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Form1;
using SQL_Form1.GUI;

namespace SQL_Form1.dbAccess
{
    class WeddingListDBAccess
    {
        private Database db;
        public WeddingListDBAccess(Database _db)
        {
            db = _db;
        }
        public WeddingList CreateWeddingList()
        {
            WeddingList wedding = new WeddingList();
            wedding.WeddingListNo = db.Rdr.GetInt32(0);
            wedding.ClientForename = db.Rdr.GetString(1);
            wedding.ClientSurname = db.Rdr.GetString(2);
            wedding.HouseNumber = db.Rdr.GetInt32(3);
            wedding.StreetName = db.Rdr.GetString(4);
            wedding.TownName = db.Rdr.GetString(5);
            wedding.PostCode = db.Rdr.GetString(6);
            wedding.ClientContactNo = db.Rdr.GetString(7);
            wedding.EventDate = db.Rdr.GetDateTime(8);
            wedding.SetupDate = db.Rdr.GetDateTime(9);
            wedding.EmployeeName = db.Rdr.GetString(10);
            return wedding;
        }

        public WeddingList WeddingList()
        {
            WeddingList Wedding = new WeddingList();
            Wedding.WeddingListNo = db.Rdr.GetInt32(0);
            Wedding.ClientSurname = db.Rdr.GetString(2);
            Wedding.ClientForename = db.Rdr.GetString(1);
            Wedding.ClientContactNo = db.Rdr.GetString(3);
            return Wedding;
        }
        public List<WeddingList> GetWeddingListObjects()
        {
            List<WeddingList> results = new List<WeddingList>();
            while (db.Rdr.Read())
                results.Add(CreateWeddingList());
            db.Rdr.Close();
            return results;
        }

        public List<WeddingList> ListGetWeddinglist()
        {
            List<WeddingList> results = new List<WeddingList>();
            while (db.Rdr.Read())
                results.Add(WeddingList());
            db.Rdr.Close();
            return results;
        }
        public void AddNewWeddingList(WeddingList WedList)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "INSERT INTO WeddingList VALUES ('" + WedList.ClientForename + "','" + WedList.ClientSurname + "'," + WedList.HouseNumber + ",'" + WedList.StreetName + "','" + WedList.TownName + "','" + WedList.PostCode + "','" + WedList.ClientContactNo + "','" + WedList.EventDate.ToString("MM/dd/yyyy") + "','"+WedList.SetupDate.ToString("MM/dd/yyyy")+"','" + WedList.EmployeeName + "')";
            db.Cmd.ExecuteNonQuery();
        }

        public void GetAllWeddingList(string name)
        {
            string sqlCmd = $"SELECT * FROM WeddingList where CONCAT(ClientForename, ' ', ClientSurname) = '{name}'";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }

        public void GetWL()
        {
            string sqlCmd = "SELECT WeddingListNo, ClientForename, ClientSurname, ClientContactNo From WeddingList";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }
    }
}