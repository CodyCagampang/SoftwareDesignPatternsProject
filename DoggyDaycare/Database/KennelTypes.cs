using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DoggyDaycare.Database
{
    class KennelTypes
    {
        string kennelType;
        string significance;

        public KennelTypes(string KennelType, string Significance)
        {
            kennelType = KennelType;
            significance = Significance;
        }

        public static DataSet getKennelTypes()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery = "SELECT * FROM KennelTypes ORDER BY KennelType";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            conn.Close();

            return ds;

            
        }
    }
}
