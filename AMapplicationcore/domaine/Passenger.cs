using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationcore.domaine
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }
        public string PassportNumber { get; set; }
        public int TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }


        // polymprphisme par signature
        //1

        public bool checkProfile(string name, string surname)
        {
            return LastName == surname && FirstName.Equals(name);
        }

        public bool checkProfile(string name, string surname, string email)
        {
            return LastName == surname && FirstName.Equals(name) && email == EmailAddress;
        }

        public bool Login(string name, string surname, string email = null)
        {
            if (email == null)
            {
                return checkProfile(name, surname);
            }
            else
            {
                return checkProfile(name, surname, email);
            }
        }
        

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger!");
        }

       public void UpperFullName()
{
    FirstName = FirstName?.ToUpper();
    LastName = LastName?.ToUpper();
}
    }

}
