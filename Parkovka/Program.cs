using Parkovka;

class Program
{
    static void Main(string[] args)
    {
        var pL = new Parking();
        pL.Accommodate(new Car() { Number = "756", Make = "Nissan" });
        pL.Accommodate(new Car() { Number = "001", Make = "Uaz" });
        pL.Accommodate(new Car() { Number = "777", Make = "Toyota" });
        foreach (var c in pL.CarList())
        {
            Console.WriteLine(c.Make);
        }
        pL.TurnOutTheCarWithNumber("777");
        foreach (var c in pL.CarList())
        {
            Console.WriteLine(c.Make);
        }
    }
}
