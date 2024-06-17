namespace Task5.App.Entitites
{
    public abstract class Vehicle : IVehicle
    {
        public int NumberOfWheels { get; set; }
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }

        public Vehicle(int numberOfWheels, string registrationNumber, string color)
        {
            if (numberOfWheels <= 0) throw new ArgumentException("Number of wheels must be positive", nameof(numberOfWheels));
            if (string.IsNullOrEmpty(registrationNumber)) throw new ArgumentException("Registration number cannot be null or empty", nameof(registrationNumber));
            if (string.IsNullOrWhiteSpace(color)) throw new ArgumentException($"Color cannot be null or whitespace", nameof(color));

            NumberOfWheels = numberOfWheels;
            RegistrationNumber = registrationNumber.ToUpperInvariant();
            Color = color;
        }

        public string GetDetails()
        {
            return $"Vehicle has {NumberOfWheels} number of wheels\n" +
                   $"Vehicle has registration number: {RegistrationNumber}\n" +
                   $"Vehicle is: {Color}";
        }
    }
}
