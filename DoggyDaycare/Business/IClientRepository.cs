using System;
using System.Collections.Generic;
using System.Data;
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

        int? LoginClient(String email, String password);

        DataTable GetAllClients();

        Clients GetClientById(int ClientId);

        bool ExistingEmailUsed(String email, int clientId);

        bool updateClientId(int clientId, String firstName, String lastName, String email, String phoneNumber);

    }
}
