using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationcore.domaine
{
    internal class Traveller:Passenger
    {
        public int MyProperty { get; private set; }

    
    public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am a traveller!");
        }
    }
}
