using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoggyDaycare.Business;
using Oracle.ManagedDataAccess.Client;

namespace DoggyDaycare.Database
{
    public class OracleDBClientRepo : IClientRepository
    {
        public int GetNextClientId()
        {
            return Clients.getNextClientID();
        }

        public bool ExistingEmails(String emails)
        {
            return Clients.checkExistingEmails(emails) > 0;
        }

        public void RegisterClient(Clients client)
        {
            try
            {
                client.registerClient();
            }
            catch (OracleException ex)
            {
                throw new InvalidOperationException("The account could not be created", ex);
            }
        }


        public int? LoginClient(String email, String password)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String sqlQuery = "SELECT ClientID FROM Clients WHERE Email = :email AND Password = :password";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.BindByName = true;
            cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
            cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = password;

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return dr.GetInt32(0);

            }
            return null;
        }

        public DataTable GetAllClients()
        {
            return Clients.getAllClients().Tables["Clients"];
        }

        public Clients GetClientById(int ClientId)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);
                conn.Open();
                String sqlQuery = "SELECT ClientId, FirstName, LastName, Email, PhoneNum " + "FROM Clients WHERE ClientId = :clientId";
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                cmd.BindByName = true;
                cmd.Parameters.Add("clientId", DbType.Int32).Value = ClientId;
                OracleDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    return null;
                }
                return new Clients(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), "", dr.GetString(4));
            }

            catch (OracleException ex)
            {
                throw new InvalidOperationException("Client Details could not be loaded", ex);
            }

        }

        public bool ExistingEmailUsed(String email, int clientId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String sqlQuery = "SELECT COUNT(*) FROM Clients " + "WHERE Email = :email AND ClientID != :clientId";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.BindByName = true;
            cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
            cmd.Parameters.Add("clientId", OracleDbType.Int32).Value = clientId;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            return dr.GetInt32(0) > 0;
        }

        public bool updateClientId(int clientId, String firstName, String lastName, String email, String phoneNumber)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String sqlQuery = "UPDATE Clients SET FirstName = :firstName, LastName = :lastName, Email = :email, PhoneNumber = :phoneNumber " + "WHERE ClientId = :clientId";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.BindByName = true;
            cmd.Parameters.Add("firstName", OracleDbType.Varchar2).Value = firstName;
            cmd.Parameters.Add("lastName", OracleDbType.Varchar2).Value = lastName;
            cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
            cmd.Parameters.Add("phoneNumber", OracleDbType.Int32).Value = phoneNumber;

            return cmd.ExecuteNonQuery() == 1;
        }
    }
}
