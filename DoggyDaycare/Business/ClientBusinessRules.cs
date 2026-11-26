using System;
using System.Collections.Generic;
using System.Data;
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

        public int LoginClient(String email, String password)
        {
            if (String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Both the email and the password must be entered");
            }

            int? clientId = clientRepo.LoginClient(email, password);
            if (!clientId.HasValue)
            {
                throw new ArgumentException($"{nameof(clientId)} does not exist");
            }
            else
            {
                return clientId.Value;
            }

        }

        public DataTable GetAllClients()
        {
            return clientRepo.GetAllClients();
        }

        public void UpdateClientDetails(int clientId, String firstName, String lastName, String email, String phoneNumber)
        {
            if (clientId <= 0)
            {
                throw new ArgumentException("Please login first");
            }

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                throw new ArgumentException("All fields must be entered");
            }

            firstName = firstName.Trim();
            lastName = lastName.Trim();
            email = email.Trim();
            phoneNumber = phoneNumber.Trim();

            if (phoneNumber.Length < 9 || phoneNumber.Length > 12 || !phoneNumber.All(char.IsDigit)) {
                throw new ArgumentException("Phone number must be 9-12 digits");

            }
            int atCount = 0;
            foreach (char character in email)
            {
                if (character == '@')
                {
                    atCount++;
                }

                if (char.IsWhiteSpace(character))
                {
                    throw new ArgumentException("Email cannot contain spaces");
                }
            }

            if (atCount != 1 || email.StartsWith('@') || email.EndsWith('@'))
            {
                throw new ArgumentException("Please enter a valid email");
            }

            if (clientRepo.ExistingEmailUsed(email, clientId))  {
                throw new ArgumentException("That email belongs to another client");
            }

            bool updated = clientRepo.updateClientId(clientId, firstName, lastName, email, phoneNumber);

            if (!updated)
            {
                throw new InvalidOperationException("Client Account could not be found");
            } 
        }

            
            
        }
    }


