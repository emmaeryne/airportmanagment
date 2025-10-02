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
        public IList<DateTime> GetFlightDates(DateTime startDate, DateTime endDate);
        
        public void Showflight(Plane P);
        public double GetAverageDuration(string destination);
        public IEnumerable<Flight> GetFlightsOrderedByDuration();
        public IEnumerable<Passanger> GetTop3OldestTravellers(Flight flight);
        public void ShowFlightsGroupedByDestination();

    }
}
