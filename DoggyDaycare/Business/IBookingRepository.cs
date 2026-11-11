using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Business
{
    public interface IBookingRepository
    {
        int SaveBooking(Dogs dog, Reservations reservations, String kennelType, decimal dailyRate, decimal totalCost);




    }
}
