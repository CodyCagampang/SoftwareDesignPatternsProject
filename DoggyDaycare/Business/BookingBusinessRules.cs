using DoggyDaycare.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Business
{
    public class BookingBusinessRules
    {
        private readonly IBookingRepository repository;

        public BookingBusinessRules(IBookingRepository repository)
        {
            this.repository = repository;
        }
        public static int GetTotalDays(DateTime startDate, DateTime endDate, DateTime today)
        {
            startDate = startDate.Date;
            endDate = endDate.Date;

            if (startDate >= endDate)
            {
                throw new ArgumentException("The start date must be before the end date!");
            }

            if (startDate < today.Date)
            {
                throw new ArgumentException("Check in must be today or in the future!");
            }

            int totalDays = (endDate - startDate).Days;

            if (totalDays < 1 || totalDays > 31)
            {
                throw new ArgumentException("The Number of Days must range between 1 - 31 Days!");
            }

            return totalDays;
        }


        // Context class --> Implements the strategy interface
        public static bool isWeightValid(String kennelType, double weight)
        {
            IStrategyPatternDogWeight kennelWeight;
            switch(kennelType)
            {
                case "S":
                    kennelWeight = new SmallKennelWeight();
                    break;
                case "M":
                    kennelWeight = new MediumKennelWeight();
                    break;
                case "L":
                    kennelWeight = new LargeKennelWeight();
                    break;
                default:
                    return false;
            }
            return kennelWeight.validateDogWeight(weight);
        }

        public static decimal CalculateTotalCost(int totalDays, decimal dailyRate)
        {
            if(totalDays < 1 || totalDays > 31)
            {
                throw new ArgumentException("Booking must be between 1 and 31 days");
            }

            if(dailyRate <= 0)
            {
                throw new ArgumentException("Daily Rate must be greater than zero");
            }

            return dailyRate * totalDays;
        }

        public int BookKennel(Dogs dog, Reservations reservation,  string kennelType, decimal dailyRate)
        {
            if (dog == null || reservation == null)
            {
                throw new ArgumentException(
                    "Dog and reservation details must be provided.");
            }

            if (dog.getClientID() <= 0 || dog.getClientID() != reservation.getClientID() || reservation.getKennelID() <= 0)
            {
                throw new ArgumentException(
                    "A valid client and kennel must be selected.");
            }

            DogBusinessRules dogRules = new DogBusinessRules();

            DogBusinessRules.ValidateDogWeight(dog.getDogName(), dog.getDogBreed(), dog.getDogWeight());

            if (!isWeightValid(kennelType, dog.getDogWeight()))
            {
                throw new ArgumentException(
                    "The dog's weight is unsuitable for this kennel.");
            }

            int totalDays = GetTotalDays(reservation.getStartDate(), reservation.getEndDate(),DateTime.Today);

            decimal totalCost = CalculateTotalCost(totalDays, dailyRate);

            return repository.SaveBooking(dog, reservation, kennelType, dailyRate, totalCost);
        }

        public DataTable getConfirmedReservation(int clientID)
        {
            return repository.GetConfirmedReservations(clientID);
        }

        public void CancelReservation(int reservationId, int clientId)
        {
            DataTable results = repository.GetReservationForClient(reservationId, clientId);
            if (results.Rows.Count == 0)
            {
                throw new InvalidOperationException("Reservation not found.");
            }

            DataRow reservation = results.Rows[0];

            if (reservation["ResStatus"].ToString() != "Confirmed")
            {
                throw new InvalidOperationException("Only Confirmed Kennel Statuses can be cancelled");
            }

            DateTime startDate = Convert.ToDateTime(reservation["startDate"]);
            DateTime cancellationPeriod = DateTime.Now.AddHours(72);

            if (startDate < cancellationPeriod)
            {
                throw new InvalidOperationException("You must cancel at least 72 hours before check-in.");
            }

            bool cancelled = repository.TryCancelReservationForClient(reservationId, clientId, cancellationPeriod);
            if (!cancelled)
            {
                throw new InvalidOperationException("This reservation is no longer cancellable.");
            }
        }





    }
}
