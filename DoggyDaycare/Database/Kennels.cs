using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Oracle.ManagedDataAccess.Client;

namespace DoggyDaycare.Database
{
   public class Kennels
    {
        private int kennelID;
        private string kennelType;
        private string description;
        private string kennelCondition;
        private decimal dailyRate;
        private string status;

        public Kennels()
        {
            kennelID = 0;
            kennelType = "";
            description = "";
            kennelCondition = "";
            dailyRate = 0;
            status = "";
        }

        public Kennels(int kennelID, string kennelType, string description, string kennelCondition, decimal dailyRate, string status)
        {
            this.kennelID = kennelID;
            this.kennelType = kennelType;
            this.description = description;
            this.kennelCondition = kennelCondition;
            this.dailyRate = dailyRate;
            this.status = status;
        }

        // Getters
        public int getKennelID() {
            return kennelID; 
        }
        public string getKennelType() {
            return kennelType; 
        }
        public string getKennelDescription() {
            return description; 
        }
        public string getKennelCondition() {
            return kennelCondition; 
        }
        public decimal getDailyRate() {
            return dailyRate; 
        }
        public string getStatus() {
            return status; 
        }

        // Setters
        public void setKennelID(int KennelID) {
            kennelID = KennelID;
        }
        public void setKennelType(string KennelType) { 
            kennelType = KennelType; 
        }
        public void setKennelDescription(string Description) { 
            description = Description; 
        }
        public void setKennelCondition(string KennelCondition) { 
            kennelCondition = KennelCondition; 
        }
        public void setDailyRate(decimal DailyRate) { 
            dailyRate = DailyRate;
        }
        public void setStatus(string Status) { 
            status = Status; 
        }

        public void getKennel(int Id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery = "SELECT * FROM Kennels WHERE KennelID = :kennelId";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.BindByName = true;
            cmd.Parameters.Add("kennelId", OracleDbType.Int32).Value = Id;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setKennelID(dr.GetInt32(0));
            setKennelType(dr.GetString(1));
            setKennelDescription(dr.GetString(2));
            setKennelCondition(dr.GetString(3));
            setDailyRate(dr.GetDecimal(4));
            setStatus(dr.GetString(5));

            conn.Close();
        }

        // Use Case ID 1: Add Kennels Function
        public void addKennel()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery = "INSERT INTO Kennels " + "(KennelID, KennelType, Description, KennelCondition, DailyRate, Status) " + "VALUES (:kennelId, :kennelType, :description, :kennelCondition, :dailyRate, :status)";
            OracleCommand cmd = new OracleCommand( sqlQuery, conn);
            cmd.BindByName = true;

            cmd.Parameters.Add("kennelId", OracleDbType.Int32).Value = kennelID;
            cmd.Parameters.Add("kennelType", OracleDbType.Varchar2).Value = kennelType;
            cmd.Parameters.Add("description", OracleDbType.Varchar2).Value = description;
            cmd.Parameters.Add("kennelCondition", OracleDbType.Varchar2).Value = kennelCondition;
            cmd.Parameters.Add("dailyRate", OracleDbType.Decimal).Value = dailyRate;
            cmd.Parameters.Add("status", OracleDbType.Varchar2).Value = status;


            cmd.ExecuteNonQuery();
            conn.Close();
        }

      


        // Use Case ID 3 --> Update a Kennel
        public void updateKennel()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            string sqlQuery = "UPDATE Kennels SET " + "KennelType = :kennelType, " + "Description = :description, " + "KennelCondition = :kennelCondition, " + "DailyRate = :dailyRate, " + "Status = :status, " + "WHERE KennelId = :kennelId";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.BindByName = true;
            cmd.Parameters.Add("kennelType", OracleDbType.Varchar2).Value = kennelType;
            cmd.Parameters.Add("description", OracleDbType.Varchar2).Value = description;
            cmd.Parameters.Add("kennelCondition", OracleDbType.Varchar2).Value = kennelCondition;
            cmd.Parameters.Add("dailyRate", OracleDbType.Decimal).Value = dailyRate;
            cmd.Parameters.Add("status", OracleDbType.Varchar2).Value = status;
            cmd.Parameters.Add("kennelId", OracleDbType.Int32).Value = kennelID;

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        

        /*public static DataSet findKennels(string specificKennel)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery = "SELECT KennelID, KennelType, DailyRate " +
                "FROM Kennels WHERE KennelID = " + specificKennel + " ORDER BY KennelID";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Kennels");

            conn.Close();
            return ds;
        }
        */

        /*
        public static DataSet typeResults(string type)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery = "SELECT KennelID, KennelType, DailyRate, Description, KennelCondition, Status " +
             "FROM Kennels WHERE KennelType = '" + type + "' " +
             "AND Status = 'Available' " +
             "ORDER BY KennelID";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Kennels"); 

            conn.Close();
            return ds;
        }
        */

        /*
        public static void updateKennelStatus(int kennelID)
        {
            OracleConnection conn = new OracleConnection( DBConnect.oradb);
            conn.Open();

            string sqlQuery = "UPDATE Kennels SET Status = 'Unavailable' WHERE KennelID = " + kennelID;
            OracleCommand cmd = new OracleCommand( sqlQuery, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        */

        /*
        public static void updateKennelStatusAfterCancellation(int kennelID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery = "UPDATE Kennels SET Status = 'Available' WHERE KennelID = " + kennelID;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        */


        public static DataSet getAllKennels()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery = "SELECT KennelID, KennelType, DailyRate FROM Kennels ORDER BY KennelType";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Kennel");

            conn.Close();
            return ds;
        }

        public static DataSet getKennelConditions()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery = "SELECT DISTINCT KennelCondition FROM Kennels ORDER BY KennelCondition"; /* https://www.w3schools.com/sql/trysql.asp?filename=trysql_select_distinct */
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Close();
            return ds;
        }

        public static DataSet getKennelStatuses()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery = "SELECT DISTINCT Status FROM Kennels ORDER BY Status"; /* https://www.w3schools.com/sql/trysql.asp?filename=trysql_select_distinct */
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Close();
            return ds;
        }





        

        public static int getNextKennelID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery = "SELECT MAX(KennelID) FROM Kennels";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            int nextId;
            dr.Read();
            if (dr.IsDBNull(0))
            {
                nextId = 1;
            }
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            conn.Close();
            return nextId;
        }
    }
}
