namespace MediatorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var callCenter = new CabCallCenter();

            var passenger1 = new Passenger("Passenger1", "112 steet", 10);
            var passenger2 = new Passenger("Passenger2", "13456 steet", 25);

            var cab1 = new Cab("Cab1", 11, true);
            var cab2 = new Cab("Cab2", 22, true);

            callCenter.Register(cab1);
            callCenter.Register(cab2);

            callCenter.BookCab(passenger1);
            callCenter.BookCab(passenger2);

            Console.ReadLine();
        }
    }
}