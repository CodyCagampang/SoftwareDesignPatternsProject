using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Oracle.ManagedDataAccess.Client;

namespace DoggyDaycare
{
    class Kennels
    {
        private int kennelID;
        private String kennelType;
        private String description;
        private String kennelCondition;
        private decimal dailyRate;
        private String status;

        public Kennels()
        {
            this.kennelID = 0;
            this.kennelType = "";
            this.description = "";
            this.kennelCondition = "";
            this.dailyRate = 0;
            this.status = "";
        }

        public Kennels(int kennelID, string kennelType, string description, string kennelCondition, decimal dailyRate, String status)
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
            return this.kennelID; 
        }
        public String getKennelType() {
            return this.kennelType; 
        }
        public String getKennelDescription() {
            return this.description; 
        }
        public String getKennelCondition() {
            return this.kennelCondition; 
        }
        public decimal getDailyRate() {
            return this.dailyRate; 
        }
        public String getStatus() {
            return this.status; 
        }

        // Setters
        public void setKennelID(int KennelID) {
            kennelID = KennelID;
        }
        public void setKennelType(String KennelType) { 
            kennelType = KennelType; 
        }
        public void setKennelDescription(String Description) { 
            description = Description; 
        }
        public void setKennelCondition(String KennelCondition) { 
            kennelCondition = KennelCondition; 
        }
        public void setDailyRate(decimal DailyRate) { 
            dailyRate = DailyRate;
        }
        public void setStatus(String Status) { 
            status = Status; 
        }

        public void getKennel(int Id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "SELECT * FROM Kennels WHERE KennelID = " + Id;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
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

            String sqlQuery = "INSERT INTO Kennels Values (" +
                this.kennelID + ",'" +
                this.kennelType + "','" +
                this.description + "','" +
                this.kennelCondition + "'," +
                this.dailyRate.ToString() + ",'" +
                this.status + "')";

            OracleCommand cmd = new OracleCommand( sqlQuery, conn);
           

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // Use Case ID 2 --> Delete A Kennel
        public void deleteKennel()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open(); // <— if slow or blocked, UI freezes here

            String sqlQuery = "DELETE FROM Kennels WHERE KennelId = " + this.kennelID;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery(); // <— this line hangs the UI

            conn.Close();
        }


        // Use Case ID 3 --> Update a Kennel
        public void updateKennel()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String sqlQuery = "UPDATE Kennels SET " +
                "KennelType = '" + this.kennelType + "'," +
                "Description = '" + this.description + "'," +
                "KennelCondition = '" + this.kennelCondition + "'," +
                "DailyRate = " + this.dailyRate + "," +
                "Status = '" + this.status + "' " +
                "WHERE KennelId = " + this.kennelID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        

        public static DataSet findKennels(string specificKennel)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "SELECT KennelID, KennelType, DailyRate " +
                "FROM Kennels WHERE KennelID = " + specificKennel + " ORDER BY KennelID";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Kennels");

            conn.Close();
            return ds;
        }

        public static DataSet typeResults(string type)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "SELECT KennelID, KennelType, DailyRate, Description, KennelCondition, Status " +
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

        public static void updateKennelStatus(int kennelID)
        {
            OracleConnection conn = new OracleConnection( DBConnect.oradb);
            conn.Open();

            String sqlQuery = "UPDATE Kennels SET Status = 'Unavailable' WHERE KennelID = " + kennelID;
            OracleCommand cmd = new OracleCommand( sqlQuery, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void updateKennelStatusAfterCancellation(int kennelID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "UPDATE Kennels SET Status = 'Available' WHERE KennelID = " + kennelID;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }


        public static DataSet getAllKennels()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "SELECT KennelID, KennelType, DailyRate FROM Kennels ORDER BY KennelType";
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

            String sqlQuery = "SELECT DISTINCT KennelCondition FROM Kennels ORDER BY KennelCondition"; /* https://www.w3schools.com/sql/trysql.asp?filename=trysql_select_distinct */
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

            String sqlQuery = "SELECT DISTINCT Status FROM Kennels ORDER BY Status"; /* https://www.w3schools.com/sql/trysql.asp?filename=trysql_select_distinct */
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

            String sqlQuery = "SELECT MAX(KennelID) FROM Kennels";
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
