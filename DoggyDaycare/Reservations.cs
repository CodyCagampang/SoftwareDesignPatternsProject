using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace DoggyDaycare
{
    class Reservations
    {
        private int resID;
        private int clientID;
        private int kennelID;
        private int dogID;
        private DateTime startDate;
        private DateTime endDate;
        private String resStatus;
        private double totalCost;

        public Reservations()
        {
            this.resID = 0;
            this.clientID = 0;
            this.kennelID = 0;
            this.dogID = 0;
            startDate = DateTime.Now;
            endDate = DateTime.Now;
            this.resStatus = "";
            this.totalCost = 0;

        }
        public Reservations(int resID, int clientID, int kennelID, int dogID, DateTime startDate, DateTime endDate, String resStatus, double totalCost)
        {
            this.resID = resID;
            this.clientID = clientID;
            this.kennelID = kennelID;
            this.dogID = dogID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.resStatus = resStatus;
            this.totalCost = totalCost;
        }

        // Setters
        public int getResID()
        {
            return this.resID;
        }

        public int getClientID()
        {
            return this.clientID;
        }

        public int getKennelID()
        { 
          return this.kennelID;
        }

        public int getDogID()
        {
            return this.dogID;
        }

        public DateTime getStartDate()
        {
            return this.startDate;
        }

        public DateTime getEndDate()
        {
            return this.endDate;
        }

        public String getResStatus()
        {
            return this.resStatus;
        }

        public double getTotalCost()
        {
            return this.totalCost;
        }

        // Getters
        public void setResID(int ResID)
        {
            resID = ResID;
        }

        public void setClientID(int ClientID)
        {
            clientID = ClientID;
        }

        public void setKennelID(int KennelID)
        {
            kennelID = KennelID;
        }

        public void setDogID(int DogID)
        {
            dogID = DogID;
        }

        public void setStartDate(DateTime StartDate)
        {
            startDate = StartDate;
        }

        public void setEndDate(DateTime EndDate)
        {
            endDate = EndDate;
        }

        public void setResStatus(String ResStatus)
        {
            resStatus = ResStatus;
        }

        public void setTotalCost(double TotalCost)
        {
            totalCost = TotalCost;
        }

        public void confirmReservation()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();


            String sqlQuery = "INSERT INTO Reservations (ResID, ClientID, KennelID, DogID, StartDate, EndDate, ResStatus, TotalCost) VALUES (" +
            this.resID + ", " +
            this.clientID + ", " +
            this.kennelID + ", " +
            this.dogID + ", " +
            "'" + String.Format("{0:dd-MMM-yyyy}", this.startDate) + "', " +
            "'" + String.Format("{0:dd-MMM-yyyy}", this.endDate) + "', " +
            "'" + this.resStatus + "', " +
            this.totalCost + ")";


            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataSet retrieveAllReservations(int clientID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "SELECT * FROM Reservations WHERE ClientID = " + clientID + " AND ResStatus = 'Confirmed'";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Reservations");
            conn.Close();
            return ds;
        }
        public static int getNextReservationID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "SELECT MAX(ResID) FROM Reservations";
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

        public void getReservation(int resID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String sqlQuery = "SELECT * FROM Reservations WHERE ResID = " + resID;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                setResID(dr.GetInt32(0));
                setClientID(dr.GetInt32(1));
                setKennelID(dr.GetInt32(2));
                setDogID(dr.GetInt32(3));
                setStartDate(dr.GetDateTime(4));
                setEndDate(dr.GetDateTime(5));
                setResStatus(dr.GetString(6));
                setTotalCost(Convert.ToDouble(dr.GetDecimal(7)));
            }
            conn.Close();
        }

        public static int getReservationCount(int kennelID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "SELECT COUNT(*) FROM Reservations WHERE KennelID = " + kennelID;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 0;
            if(dr.Read())
            {
                count = dr.GetInt32(0);
            }
            conn.Close();
            return count;
        }
        public void updateReservationStatus()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery = "UPDATE Reservations SET ResStatus = '" + this.resStatus + "' WHERE ResID = " + this.resID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

    }





}

