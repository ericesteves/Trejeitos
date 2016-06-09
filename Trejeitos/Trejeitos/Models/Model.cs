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
            string strConn = @"Data Source = Notebook;
                Initial Catalog= bdTrejeitos;
                Integrated Security= false;
                User Id = sa;
                Password = 10274011";
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

    }
}