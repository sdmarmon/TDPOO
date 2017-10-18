using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Prospect
    {
        private string email;
        private string firstName;
        private DateTime lastContact;
        private string lastName;
        private string notes;

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public DateTime LastContact
        {
            get
            {
                return lastContact;
            }

            set
            {
                lastContact = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Notes
        {
            get
            {
                return notes;
            }

            set
            {
                notes = value;
            }
        }

        public Prospect()
        {
            Email = "mrx@gmail.com";
            FirstName = "Mister";
            LastName = "X";
            LastContact = DateTime.Now;
            Notes = "Je suis un faux.";
        }

        public Prospect(string lastName, string firstName, string email, DateTime lastContact)
        {
            this.lastName = lastName;
            FirstName = firstName;
            Email = email;
            LastContact = lastContact;
        }

        public Prospect(string lastName, string firstName, string email, DateTime lastContact, string notes)
        {
            this.lastName = lastName;
            FirstName = firstName;
            Email = email;
            LastContact = lastContact;
            Notes = notes;
        }

        public override string ToString()
        {
            return LastName+" "+FirstName;
        }
    }
}
