using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoggyDaycare.Business;
using Oracle.ManagedDataAccess.Client;

namespace DoggyDaycare.Database
{
    public class OracleDBClientRepo : IClientRepository
    {
        public int GetNextClientId()
        {
            return Clients.getNextClientID();
        }

        public bool ExistingEmails(String emails)
        {
            return Clients.checkExistingEmails(emails) > 0;
        }

        public void RegisterClient(Clients client)
        {
            try
            {
                client.registerClient();
            }
            catch(OracleException ex)
            {
                throw new InvalidOperationException("The account could not be created", ex);
            }
        }
    }
}
