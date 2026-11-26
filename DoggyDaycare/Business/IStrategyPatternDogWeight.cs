using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Business
{
    // Defines the way in which dog weights will be validated against kennels
    public interface IStrategyPatternDogWeight
    {
        bool validateDogWeight(double weight);
    }
}
