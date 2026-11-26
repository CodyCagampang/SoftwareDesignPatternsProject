using DoggyDaycare.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Business
{
    public interface IOracleDBKennelRepo
    {
        List<KennelTypeOptions> GetKennelTypes();
        List<String> GetKennelConditions();

        List<String> GetKennelStatus();

        void AddKennel(Kennels kennel);
        List<AvailableKennel> GetAvailableKennels(String size);

        DataTable SearchByKennelId(int id);
        bool UpdateKennel(int id, String kennelType, String description, String kennelCondiion, decimal dailyRate, String status);
    }
}
