using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Business
{
    public class KennelTypeOptions
    {
        public String TypeCode { get; }
        public String Description { get; }

        public KennelTypeOptions(String  TypeCode, String Description)
        {
            this.TypeCode = TypeCode;
            this.Description = Description;
        }

        
    }
}
