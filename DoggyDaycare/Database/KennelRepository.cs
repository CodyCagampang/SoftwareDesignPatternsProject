using DoggyDaycare.Business;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public List<String> GetKennelConditions()
        {
            List<String> conditions = new List<String>();
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            string sqlQuery = "SELECT DISTINCT KennelCondition FROM Kennels ORDER BY KennelCondition";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                String condition = row["KennelCondition"].ToString();
                conditions.Add(condition);
            }
            return conditions;
        }

        public List<String> GetKennelStatus()
        {
            List<String> status = new List<String>();
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            string sqlQuery = "SELECT DISTINCT Status FROM Kennels ORDER BY Status";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                string statuses = row["Status"].ToString();
                status.Add(statuses);
            }
            return status;


        }

        public void AddKennel(Kennels kennel)
        {

            try
            {
                string sqlQuery = "INSERT INTO Kennels " +
                "(KennelID, KennelType, Description, KennelCondition, DailyRate, Status) " +
                "VALUES (:kennelId, :kennelType, :description, " +
                ":kennelCondition, :dailyRate, :status)";

                OracleConnection conn = new OracleConnection(DBConnect.oradb);
                conn.Open();
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                cmd.BindByName = true;
                cmd.Parameters.Add("KennelID", kennel.getKennelID());
                cmd.Parameters.Add("KennelType", kennel.getKennelType());
                cmd.Parameters.Add("Description", kennel.getKennelDescription());
                cmd.Parameters.Add("KennelCondition", kennel.getKennelCondition());
                cmd.Parameters.Add("DailyRate", kennel.getDailyRate());
                cmd.Parameters.Add("Status", kennel.getStatus());
                cmd.ExecuteNonQuery();
            }
            catch(OracleException ex)
            {
                throw new InvalidOperationException("The kennel could not be saved. Please try again.", ex);
            }
        }

        public List<AvailableKennel> GetAvailableKennels(String size)
        {
            List<AvailableKennel> kennelRows = new List<AvailableKennel>();
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery = "SELECT KennelID, KennelType, DailyRate, Description, KennelCondition, Status " +
             "FROM Kennels WHERE KennelType = :kennelSize AND Status = 'Available' " + "ORDER BY KennelID";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.BindByName = true;

            cmd.Parameters.Add("kennelSize", size);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                AvailableKennel newKennel = new AvailableKennel {
                    KennelID = Convert.ToInt32(row["KennelID"]),
                    KennelType = row["KennelType"].ToString(),
                    DailyRate = Convert.ToDecimal(row["DailyRate"]),
                    Description = row["Description"].ToString(),
                    KennelCondition = row["KennelCondition"].ToString(),
                    Status = row["Status"].ToString()
                };
                kennelRows.Add(newKennel);
        }
            return kennelRows;
        }
    


    }
}
    




       
   


