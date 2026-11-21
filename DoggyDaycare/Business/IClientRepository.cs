using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Business
{
    public interface IClientRepository
    {
        int GetNextClientId();
        bool ExistingEmails(String emails);
        void RegisterClient(Clients client);
    }
}
