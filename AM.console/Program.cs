

using AM.applicationcore.domaine;
using AMapplicationcore;

Plane p1 = new Plane();
p1.Capacity = 200;
p1.MAnufactureDate = new DateTime(2003,04,29);
p1.PlaneType = PlaneType.Boing; 
Plane p2 = new Plane(300,DateTime.Now,PlaneType.Airbus);
Console.WriteLine(p1.ToString());
Console.WriteLine(p2.ToString());
Plane P3 = new Plane
{
    Capacity = 200,
    PlaneType = PlaneType.Boing,

};

Passenger pass1 = new Passenger
{
    FirstName = "Test",
    LastName = "Test" };
Passenger pass2 = new Passenger
{
    FirstName = "Test",
    LastName = "Test",
    EmailAddress = "Test",
};
    Console.WriteLine(pass1.Login("Test", "Test"));
Console.WriteLine(pass1.Login("Test", "Test", "testc@email")); 
