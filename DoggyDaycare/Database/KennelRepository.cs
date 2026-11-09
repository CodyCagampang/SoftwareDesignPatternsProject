using DoggyDaycare.Business;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Database
{
    public class KennelRepository : IKennelRepository
    {
        public List<KennelTypeOptions> GetKennelTypes()
        {
            List<KennelTypeOptions> kennel = new List<KennelTypeOptions>();
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            string sqlQuery = "SELECT * FROM KennelTypes ORDER BY KennelType";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                String typeCode = row["KennelType"].ToString();
                String description = row["Significance"].ToString();

                KennelTypeOptions options = new KennelTypeOptions(typeCode, description);
                kennel.Add(options);
            }
            return kennel;
        }
    }
}
    




        /*
        int GetNextKennelId();
        public List<KennelTypeOptions> GetKennelTypes()
        {
            List<KennelTypeOptions> kennel = new List<KennelTypeOptions>();
            
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery = "SELECT * FROM KennelTypes ORDER BY KennelType";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            conn.Close();

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

            }
            // return ds;

        }
        */

    /*
        List<String> GetKennelConditions();
        List<String> GetKennelStatus();
    */
   


