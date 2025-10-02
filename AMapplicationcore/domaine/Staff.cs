using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationcore.domaine
{
    internal class Staff: Passenger
    {
        public DateTime EmploymentDaate { get; set; }
        public string Function { get; set; }
        public double Salary {  get; set; }
    
public override void PassengerType()
    {
        base.PassengerType();
        Console.WriteLine("I am a staff member!");
    }
}

}
