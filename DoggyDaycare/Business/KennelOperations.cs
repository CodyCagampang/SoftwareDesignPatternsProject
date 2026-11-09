using DoggyDaycare.Database;
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

        public List<String> GetKennelConditions()
        {
            return repository.GetKennelConditions();
        }

        public List<String> GetKennelStatus()
        {
            return repository.GetKennelStatus();
        }

        public bool IsDailyRateValid(decimal dailyRate)
        {
            return dailyRate > 0;
        }

        public bool IsDescriptionValid(string description)
        {
            return !string.IsNullOrWhiteSpace(description);
        }

        public void AddKennel(Kennels kennel)
        {

            if (kennel == null)
            {
                throw new ArgumentNullException(nameof(kennel));
            }

            if (String.IsNullOrWhiteSpace(kennel.getKennelType()) || String.IsNullOrWhiteSpace(kennel.getKennelDescription()) || String.IsNullOrWhiteSpace(kennel.getKennelCondition()) || String.IsNullOrWhiteSpace(kennel.getStatus())) {
                throw new ArgumentException("All Fields must be entered!");
            }

            if (!IsDailyRateValid(kennel.getDailyRate())) {
                throw new ArgumentException("Daily Rate must be a valid decimal!");
            }

            repository.AddKennel(kennel);
    }
    }
}
