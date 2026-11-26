using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Business
{
    // Concrete Classes --> Implements the interface their own way
    public class SmallKennelWeight : IStrategyPatternDogWeight
    {
        public bool validateDogWeight(double weight)
        {
            return weight > 0 && weight <= 10;
        }
    }

    public class MediumKennelWeight : IStrategyPatternDogWeight
    {
        public bool validateDogWeight(double weight)
        {
            return weight >= 11 && weight <= 20;
        }
    }

    public class LargeKennelWeight : IStrategyPatternDogWeight
    {
        public bool validateDogWeight(double weight)
        {
            return weight >= 21 && weight <= 60;
        }
    }
}