using System;
using SQL_Form1.Objects;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Form1.Objects
{
    public class Database
    {
        SqlCommand cmd;
        SqlConnection conn;    
        SqlDataReader rdr;

        public Database()
        {

        }
        public SqlCommand Cmd { get => cmd; set => cmd = value; }
        public SqlConnection Conn { get => conn; set => conn = value; }
        public SqlDataReader Rdr { get => rdr; set => rdr = value; }

       
        public bool Connect()
        {
            SqlConnectionStringBuilder scstrbuild = new SqlConnectionStringBuilder();
            scstrbuild.DataSource = "(LocalDB)\\MSSQLLocalDB";
            scstrbuild.AttachDBFilename = "|DataDirectory|HouseholdGoods.mdf";
            scstrbuild.InitialCatalog = "ProjectManagement";
            scstrbuild.IntegratedSecurity = true;
            conn = new SqlConnection(scstrbuild.ToString());
            try
            {
                conn.Open();
                return true;  
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
