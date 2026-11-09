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
    }
}
