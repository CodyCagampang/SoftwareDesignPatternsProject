using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace DoggyDaycare
{
    class Dogs
    {
        private int DogID;
        private int ClientID;
        private String DogName;
        private String DogBreed;
        private double DogWeight;

        public Dogs()
        {
            this.DogID = 0;
            this.ClientID = 0;
            this.DogName = "";
            this.DogBreed = "";
            this.DogWeight = 0.00;
        }

        public Dogs(int DogId, int ClientId, string dogName, string dogBreed, double dogWeight)
        {
            this.DogID = DogId;
            this.ClientID = ClientId;
            this.DogName = dogName;
            this.DogBreed = dogBreed;
            this.DogWeight = dogWeight;
        }
       
        // Getters
        public int getDogID() { return this.DogID; }
        public int getClientID() { return this.ClientID; }
        public String getDogName() { return this.DogName; }
        public String getDogBreed() { return this.DogBreed; }
        public double getDogWeight() { return this.DogWeight; }

        // Setters
        public void setDogID(int DogID) {  this.DogID = DogID;}
        public void setClientID(int ClientId) { this.ClientID = ClientId;}
        public void setDogName(String DogName) {  this.DogName = DogName;}
        public void setDogBreed(String DogBreed) { this.DogBreed= DogBreed;}
        public void setDogWeight(double dogWeight) { this.DogWeight = dogWeight;}

        public void getDogID(int Id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "SELECT * FROM Dogs WHERE DogID = " + Id;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                setDogID(dr.GetInt32(0));
                setClientID(dr.GetInt32(1));
                setDogName(dr.GetString(2));
                setDogBreed(dr.GetString(3));
                setDogWeight(dr.GetDouble(4));
            }

            conn.Close();
        }

        public void saveDogDetails()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "INSERT INTO Dogs (DogID, ClientID, DogName, DogBreed, DogWeight) VALUES (" +
                this.DogID + ", " +
                this.ClientID + ", '" +
                this.DogName + "', '" +
                this.DogBreed + "', " +
                this.DogWeight + ")";

            OracleCommand cmd = new OracleCommand( sqlQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void getDog(int dogID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "SELECT * FROM Dogs WHERE DogID = " + dogID;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                setDogID(dr.GetInt32(0));
                setClientID(dr.GetInt32(1));
                setDogName(dr.GetString(2));
                setDogBreed(dr.GetString(3));
                setDogWeight(Convert.ToDouble(dr.GetDecimal(4)));
            }

            conn.Close();
        }

        public static int getNextDogID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT MAX(DogID) FROM Dogs";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

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

