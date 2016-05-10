using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient; // <------

namespace Trejeitos.Models
{
    public abstract class Model : IDisposable
    {
        protected SqlConnection conn;

        public Model()
        {
            string strConn = "Data Source = Notebook; Initial Catalog = bdTrejeitos; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

    }
}