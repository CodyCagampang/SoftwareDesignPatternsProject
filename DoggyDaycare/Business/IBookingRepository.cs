using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Business
{
    public interface IBookingRepository
    {
        int SaveBooking(Dogs dog, Reservations reservations, String kennelType, decimal dailyRate, decimal totalCost);
        DataTable GetConfirmedReservations(int clientId);

        DataTable GetReservationForClient(int reservationId, int clientId);

       bool TryCancelReservationForClient(int reservationId, int clientId, DateTime cancellationPeriod);
    }
}
