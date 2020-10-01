using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace APIboletim.Context
{
    public class BoletimContext
    {
        SqlConnection con = new SqlConnection();

        public BoletimContext()
        {
            con.ConnectionString = "Data Source-=N -15-DEV-16/SQLEXPRESS;Initial Catalog= boletim; User ID =sa; Password = 123";
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
        }
    }
}  
