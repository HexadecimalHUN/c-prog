using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;


namespace LogicTier
{
    public class FilmData
    {
        public DataSet GetFilmDB(string connectionString)
        {
            string selectSQL = "";

            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(selectSQL, con);

            DataSet ds = new DataSet();

            return ds;

            
        }
    }
}
