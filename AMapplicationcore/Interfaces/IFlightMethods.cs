using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.applicationcore.domaine;

namespace AM.applicationcore.Interfaces
{
    public interface IFlightMethods
    {
        public IList<DateTime> GetFlightDates(string destination);
        public void GetFlights(string filterType, string filterValue);

        public void Showflight(Plane P);
        public double GetAverageDuration(string destination);
        public IEnumerable<Flight> GetFlightsOrderedByDuration();

        public void ShowFlightsGroupedByDestination();
        public IEnumerable<Traveller> SeniorTravellers(Flight flight);
    }
}
