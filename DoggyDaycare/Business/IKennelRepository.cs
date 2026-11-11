using DoggyDaycare.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Business
{
    public interface IKennelRepository
    {
        List<KennelTypeOptions> GetKennelTypes();
        List<String> GetKennelConditions();

        List<String> GetKennelStatus();

        void AddKennel(Kennels kennel);
        List<AvailableKennel> GetAvailableKennels(String size);
    }
}
