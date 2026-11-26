using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoggyDaycare.Database;
using Oracle.ManagedDataAccess.Client;

namespace DoggyDaycare
{
    public class Clients
    {
        private int clientID;
        private String firstName;
        private String lastName;
        private String email;
        private String password;
        private String phoneNumber;

        public Clients()
        {
            this.clientID = 0;
            this.firstName = "";
            this.lastName = "";
            this.email = "";
            this.password = "";
            this.phoneNumber = "";
        }

        public Clients(int clientId, string firstName, string lastName, String email, String password, String phoneNumber)
        {
            this.clientID = clientId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.phoneNumber = phoneNumber;
        }

        public int getClientID()
        {
            return this.clientID;
        }

        public String getFirstName()
        {
            return this.firstName;
        }

        public String getLastName()
        {
            return this.lastName;
        }

        public String getEmail()
        {
            return this.email;
        }

        public String getPassword()
        {
            return this.password;
        }

        public String getPhoneNumber()
        {
            return this.phoneNumber;
        }

        public void setClientID(int ClientID)
        {
            this.clientID = ClientID;
        }

        public void setFirstName(String FirstName)
        {
            this.firstName = FirstName;
        }

        public void setLastName(String LastName)
        {
            this.lastName = LastName;
        }

        public void setEmail(String Email)
        {
            this.email = Email;
        }

        public void setPhoneNumber(String PhoneNumber)
        {
            this.phoneNumber = PhoneNumber;
        }


        public void getClient(int Id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String sqlQuery = "SELECT * FROM Clients WHERE ClientID = " + Id;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                setClientID(dr.GetInt32(0));
                setFirstName(dr.GetString(1));
                setLastName(dr.GetString(2));
                setEmail(dr.GetString(3));
                setPhoneNumber(dr.GetString(5));
            }

            conn.Close();
        }

        public static int hasActiveRegistration(int clientID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String sqlQuery = "SELECT COUNT(*) FROM Reservations WHERE ClientID = :clientId AND ResStatus = 'Confirmed'";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.BindByName = true;
            cmd.Parameters.Add("clientId", OracleDbType.Int32).Value = clientID;    

            OracleDataReader dr = cmd.ExecuteReader();
            int count = 0;
            if (dr.Read())
            {
                count = dr.GetInt32(0);
            }

            conn.Close();
            return count;
        } 

        public const int LoggedInClientID = 0;

        public void getClientEmail(string email)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "SELECT * FROM Clients WHERE Email = :email";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.BindByName = true;
            cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
            OracleDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                clientID = dataReader.GetInt32(0);
                firstName = dataReader.GetString(1);
                lastName = dataReader.GetString(2);
                this.email = dataReader.GetString(3);
                password = dataReader.GetString(4);
                phoneNumber = dataReader.GetString(5);

            }
        }

        public void getClientByID(int id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "SELECT * FROM Clients WHERE ClientID = :clientId" ;
            OracleCommand cmd = new OracleCommand( sqlQuery, conn);
            cmd.BindByName = true;
            cmd.Parameters.Add("clientId", OracleDbType.Int32).Value = id;
            OracleDataReader dr= cmd.ExecuteReader();
            if (dr.Read())
            {
                this.clientID = dr.GetInt32(0);
                this.firstName = dr.GetString(1);
                this.lastName = dr.GetString(2);
                this.email = dr.GetString(3);
                this.phoneNumber = dr.GetString(5);
            }
            else
            {
                MessageBox.Show("Client Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }
    


        public void registerClient()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO Clients " + "(ClientID, FirstName, LastName, Email, Password, PhoneNum) " + "VALUES (:clientId, :firstName, :lastName, :email, :password, :phoneNumber)";
            using OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.BindByName = true;
            cmd.Parameters.Add("clientId", OracleDbType.Int32).Value = this.clientID;
            cmd.Parameters.Add("firstName", OracleDbType.Varchar2).Value = this.firstName;
            cmd.Parameters.Add("lastName", OracleDbType.Varchar2).Value = this.lastName;
            cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = this.email;
            cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = this.password;
            cmd.Parameters.Add("phoneNumber", OracleDbType.Varchar2).Value = this.phoneNumber;
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static int checkExistingEmails(string email)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery = "SELECT COUNT(*) FROM Clients WHERE Email = :email";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.BindByName = true;
            cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
            int count = 0;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                count =  dr.GetInt32(0);
               
            }

            conn.Close();
            return count;
        }

        public static int clientLogin(String email, String password)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sqlQuery = "SELECT COUNT(*) FROM Clients " + "WHERE Email = :email AND Password = :password";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.BindByName = true;
            cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
            cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = password;
            
            int count = 0;
            OracleDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                count = dr.GetInt32(0);
            }

            conn.Close();
            return count;
        }

        public static DataSet findClients(string clientID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlQuery;

            if (clientID == "")
            {
                sqlQuery = "SELECT ClientID, FirstName, LastName, Email, PhoneNum FROM Clients ORDER BY ClientID";
            }
            else
            {
                sqlQuery = "SELECT ClientID, FirstName, LastName, Email, PhoneNum FROM Clients WHERE ClientID = " + clientID + " ORDER BY ClientID";
            }

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Clients");
            conn.Close();

            return ds;
        }



        public static DataSet getAllClients()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String sqlQuery = "SELECT ClientID, FirstName, LastName, Email, PhoneNum " + " FROM Clients ORDER BY ClientID";
            OracleCommand cmd = new OracleCommand( sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Clients");

            conn.Close();
            return ds;
        }

        public static int getNextClientID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT MAX(ClientID) FROM Clients";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            int nextId;
            dr.Read();

            if(dr.IsDBNull(0))
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
