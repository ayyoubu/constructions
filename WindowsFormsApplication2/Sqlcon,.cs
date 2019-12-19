using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApplication2
{
    class Sqlcon
    {
       public SqlConnection cnx = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=construction;Integrated Security=True");
            public Sqlcon()
        {
            if (cnx.State == ConnectionState.Closed) cnx.Open();

        }


    }
}
