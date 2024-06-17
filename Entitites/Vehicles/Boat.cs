namespace Task5.App.Entitites.Vehicles
{
    internal class Boat : Vehicle
    {
        public int GuestCapacity { get; set; }
        public Boat(int numberOfWheels, string registrationNumber, string color, int guestCapacity) : base(numberOfWheels, registrationNumber, color)
        {
            GuestCapacity = guestCapacity;
        }
    }
}
