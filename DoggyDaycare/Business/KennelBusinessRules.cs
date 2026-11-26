using DoggyDaycare.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoggyDaycare.Business
{
    public class KennelBusinessRules
    {
        private readonly IOracleDBKennelRepo repository;

        public KennelBusinessRules(IOracleDBKennelRepo repository)
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

        public static bool IsDailyRateValid(decimal dailyRate)
        {
            return dailyRate > 0;
        }

        public static bool IsDescriptionValid(string description)
        {
            return !string.IsNullOrWhiteSpace(description);
        }

        public void AddKennel(Kennels kennel)
        {

            if (kennel == null)
            {
                throw new ArgumentNullException(nameof(kennel));
            }

            if (String.IsNullOrWhiteSpace(kennel.getKennelType()) || String.IsNullOrWhiteSpace(kennel.getKennelDescription()) || String.IsNullOrWhiteSpace(kennel.getKennelCondition()) || String.IsNullOrWhiteSpace(kennel.getStatus()))
            {
                throw new ArgumentException("All Fields must be entered!");
            }

            if (!IsDailyRateValid(kennel.getDailyRate()))
            {
                throw new ArgumentException("Daily Rate must be a valid decimal!");
            }

            repository.AddKennel(kennel);
        }

        public static bool isKennelSizeValid(String size)
        {
            return size == "S" || size == "M" || size == "L";
        }

        public List<AvailableKennel> GetAvailableKennels(String size)
        {
            if (!isKennelSizeValid(size))
            {
                throw new ArgumentException("Invalid Kennel Size");
            }
            return repository.GetAvailableKennels(size);
        }

        public DataTable SearchKennelById(int id)
        {
            return repository.SearchByKennelId(id);
        }

        public void UpdateKennel(Kennels kennel)
        {
            if (kennel == null)
            {
                throw new ArgumentNullException(nameof(kennel));
            }

            if (kennel.getKennelID() <= 0)
            {
                throw new ArgumentException("Please select a kennel to update");
            }

            if (!IsDescriptionValid(kennel.getKennelDescription()))
            {
                throw new ArgumentException("Please enter a kennel description");
            }

            if (!IsDailyRateValid(kennel.getDailyRate()))
            {
                throw new ArgumentException("Please enter a valid daily rate");
            }

            if(string.IsNullOrWhiteSpace(kennel.getKennelType()) || string.IsNullOrWhiteSpace(kennel.getKennelCondition()) || string.IsNullOrWhiteSpace(kennel.getStatus())) {
                throw new ArgumentException("Please select a type, condition and status");
            }

            bool updatedKennel = repository.UpdateKennel(kennel.getKennelID(), kennel.getKennelType(), kennel.getKennelDescription(), kennel.getKennelCondition(), kennel.getDailyRate(), kennel.getStatus());
        }
    }
}
