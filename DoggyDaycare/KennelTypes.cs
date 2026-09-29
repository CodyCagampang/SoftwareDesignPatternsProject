using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DoggyDaycare
{
    class KennelTypes
    {
        String kennelType;
        String significance;

        public KennelTypes(string KennelType, string Significance)
        {
            this.kennelType = KennelType;
            this.significance = Significance;
        }

        public static DataSet getKennelTypes()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "SELECT * FROM KennelTypes ORDER BY KennelType";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            conn.Close();

            return ds;

            
        }
    }
}
