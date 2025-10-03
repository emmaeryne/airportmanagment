

using AM.applicationcore.domaine;
using AM.applicationcore.Services;
using AMapplicationcore;




FlightMethods flight=new FlightMethods();
flight.Flights = TestData.listFlights;
IList<DateTime> parisFlights = flight.GetFlightDates("Paris");
foreach (var date in parisFlights)
{
    Console.WriteLine(date);
}
DateTime startDate = new DateTime(2022, 01, 01);
DateTime endDate = new DateTime(2022, 01, 08);
IList<DateTime> flightdate=flight.GetFlightDates(startDate, endDate);


foreach (var d in flightdate)
{
    Console.WriteLine(d);
}


