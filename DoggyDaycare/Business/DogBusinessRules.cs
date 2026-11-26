using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Business
{
    public class DogBusinessRules
    {
        public void ValidateDogWeight(String name, String breed, double weight)
        {
            if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(breed)) 
            {
                throw new ArgumentNullException("Dog name AND breed must be entered!");
            }

            if(double.IsNaN(weight) || weight <= 0)
            {
                throw new ArgumentException("The Dog Weight must be more than 0");
            }
        }
    }
}
