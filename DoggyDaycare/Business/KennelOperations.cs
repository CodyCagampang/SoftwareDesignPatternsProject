using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Business
{
    public class KennelOperations
    {
        private readonly IKennelRepository repository;

        public KennelOperations(IKennelRepository repository)
        {
            this.repository = repository;
        }

        public List<KennelTypeOptions> GetKennelTypes()
        {
            return repository.GetKennelTypes();
        }
    }
}
