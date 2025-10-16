

using AM.applicationcore.domaine;
using AM.applicationcore.Services;
using AMapplicationcore;


Passenger pass2 = new Passenger
{
    FirstName = "test",
    LastName = "test",
    EmailAddress = "test"
};

FlightMethods flight = new FlightMethods();
flight.Flights = TestData.listFlights;
IList<DateTime> parisFlights = flight.GetFlightDates("Paris");
foreach (var date in parisFlights)
{
    Console.WriteLine(date);
}
DateTime startDate = new DateTime(2022, 01, 01);
DateTime endDate = new DateTime(2022, 01, 08);
IList<DateTime> flightdate = flight.GetFlightDates(startDate, endDate);


foreach (var d in flightdate)
{
    Console.WriteLine(d);
    pass2.UpperFullName();
    Console.WriteLine(pass2.LastName);
    Console.WriteLine(pass2.FirstName);

}


