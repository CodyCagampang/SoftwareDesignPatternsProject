using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Business
{
    public class ClientBusinessRules
    {
        private readonly IClientRepository clientRepo;

        public ClientBusinessRules(IClientRepository clientRepo)
        {
            this.clientRepo = clientRepo;
        }

        public int GetNextClientId()
        {
            return clientRepo.GetNextClientId();
        }

        public void RegisterClients(int clientID, String firstName, String lastName, String email, String password, String phoneNumber)
        {
            if (String.IsNullOrWhiteSpace(firstName) || String.IsNullOrWhiteSpace(lastName) || String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password) || String.IsNullOrWhiteSpace(phoneNumber))
            {
                throw new ArgumentException("All fields must be entered!");
            }

            if (phoneNumber.Length < 9 || phoneNumber.Length > 12 || !phoneNumber.All(char.IsDigit))
            {
                throw new ArgumentException("Phone Number must be in between 9 and 12");
            }

            if (email.Count(c => c == '@') != 1)
            {
                throw new ArgumentException("Please enter a valid email.");
            }

            if (password.Length < 8)
            {
                throw new ArgumentException("Password must be at least 8 characters");
            }

            if (clientRepo.ExistingEmails(email))
            {
                throw new ArgumentException("This email is already being used");
            }

            Clients client = new Clients(clientID, firstName, lastName, email, password, phoneNumber);
            clientRepo.RegisterClient(client);
        }
    }
}

