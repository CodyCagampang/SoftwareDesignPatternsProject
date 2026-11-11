using DoggyDaycare.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Business
{
    public class BookingOperations
    {
        private readonly IBookingRepository repository;

        public BookingOperations(IBookingRepository repository)
        {
            this.repository = repository;
        }
        public int GetTotalDays(DateTime startDate, DateTime endDate, DateTime today)
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

        public bool isWeightValid(String kennelType, double weight)
        {
            if (kennelType == "S") 
            { 
                return weight > 0 && weight <= 10; 
            
            }

            if (kennelType == "M")
            {
                return weight >= 11 && weight <= 20;
            }

            if (kennelType == "L")
            {
                return weight >= 21 && weight <= 60;
            }

            return false;
        }

        public decimal CalculateTotalCost(int totalDays, decimal dailyRate)
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

            dogRules.ValidateDogWeight(dog.getDogName(), dog.getDogBreed(), dog.getDogWeight());

            if (!isWeightValid(kennelType, dog.getDogWeight()))
            {
                throw new ArgumentException(
                    "The dog's weight is unsuitable for this kennel.");
            }

            int totalDays = GetTotalDays(reservation.getStartDate(), reservation.getEndDate(),DateTime.Today);

            decimal totalCost = CalculateTotalCost(totalDays, dailyRate);

            return repository.SaveBooking(dog, reservation, kennelType, dailyRate, totalCost);
        }


    }
}
