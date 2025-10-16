using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AM.applicationcore.domaine
{
    public class Passenger
    {
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth”")]
        public DateTime BirthDate { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        [MinLength(3,ErrorMessage ="règles ne sont pas respectées")]
        [MaxLength(25,ErrorMessage ="règles ne sont pas respectées")]
    
        public string FirstName { get; set; }
        public int Id { get; set; }
        
        public string LastName { get; set; }
        [Key]
        [StringLength(7)]
        public string PassportNumber { get; set; }
        [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "Le numéro de téléphone doit contenir exactement 8 chiffres.")]
        public string TelNumber { get; set; }
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
