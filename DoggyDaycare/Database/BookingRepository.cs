using DoggyDaycare.Business;
using Oracle.ManagedDataAccess.Client;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Database
{
    public class BookingRepository : IBookingRepository
    {
        public int SaveBooking(Dogs dog, Reservations reservation, String kennelType, decimal dailyRate, decimal totalCost)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);
                conn.Open();
                OracleTransaction transaction = conn.BeginTransaction();
                OracleCommand cmd = conn.CreateCommand();

                cmd.BindByName = true;

                try
                {
                    String sqlQuery = "LOCK TABLE Dogs, Reservations IN EXCLUSIVE MODE";
                    cmd.CommandText = sqlQuery;
                    cmd.ExecuteNonQuery();

                    sqlQuery = "SELECT NVL(MAX(DogID), 0) + 1 FROM Dogs";
                    cmd.CommandText = sqlQuery;

                    int dogID = Convert.ToInt32(cmd.ExecuteScalar());

                    sqlQuery = "SELECT NVL(MAX(ResID), 0) + 1 FROM Reservations";
                    cmd.CommandText = sqlQuery;
                    int reservationID = Convert.ToInt32(cmd.ExecuteScalar());

                    sqlQuery = "UPDATE Kennels SET Status = 'Unavailable' " + "WHERE KennelID = :kennelID " + "AND Status = 'Available' " + "AND KennelType = :kennelType " + "AND DailyRate = :dailyRate";
                    cmd.CommandText = sqlQuery;

                    cmd.Parameters.Add("kennelID", reservation.getKennelID());
                    cmd.Parameters.Add("kennelType", kennelType);
                    cmd.Parameters.Add("dailyRate", dailyRate);

                    int changedRows = cmd.ExecuteNonQuery();

                    if(changedRows != 1)
                    {
                        throw new InvalidOperationException("The kennel is unavailable, or its details have been changed");
                    }

                    cmd.Parameters.Clear();

                    sqlQuery = "INSERT INTO Dogs " + "(DogID, ClientID, DogName, DogBreed, DogWeight) " + "VALUES (:dogID, :clientID, :dogName, :dogBreed, :dogWeight)";

                    cmd.CommandText = sqlQuery;

                    cmd.Parameters.Add("dogID", dogID);
                    cmd.Parameters.Add("clientID", dog.getClientID());
                    cmd.Parameters.Add("dogName", dog.getDogName());
                    cmd.Parameters.Add("dogBreed", dog.getDogBreed());
                    cmd.Parameters.Add("dogWeight", dog.getDogWeight());
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    sqlQuery = "INSERT INTO Reservations " + "(ResID, ClientID, KennelID, DogID, StartDate, EndDate, resStatus, totalCost)" + "VALUES (:resID, :clientID, :kennelID, :dogID, :startDate, :endDate, :resStatus, :totalCost)";
                    cmd.CommandText = sqlQuery;
                    cmd.Parameters.Add("resID", reservationID);
                    cmd.Parameters.Add("clientID", reservation.getClientID());
                    cmd.Parameters.Add("kennelID", reservation.getKennelID());
                    cmd.Parameters.Add("dogID", dogID);
                    cmd.Parameters.Add("startDate", reservation.getStartDate().Date);
                    cmd.Parameters.Add("endDate", reservation.getEndDate().Date);
                    cmd.Parameters.Add("resStatus", "Confirmed");
                    cmd.Parameters.Add("totalCost", totalCost);

                    cmd.ExecuteNonQuery();

                    transaction.Commit();

                    return reservationID;
                } catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (OracleException ex)
            {
                throw new InvalidOperationException("Booking could not be saved", ex);
            }

    } 
    }
}
