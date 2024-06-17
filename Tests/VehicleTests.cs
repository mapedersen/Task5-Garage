using Task5.Entitites;

namespace Task5.Test
{
    public class VehicleTests
    {
        [Fact]
        public void Constructor_ValidParameters_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            int expectedWheels = 4;
            string expectedRegistrationNumber = "ABC123";
            string expectedColor = "Blue";

            // Act
            TestVehicle vehicle = new(expectedWheels, expectedRegistrationNumber, expectedColor);

            // Assert
            Assert.Equal(expectedWheels, vehicle.NumberOfWheels);
            Assert.Equal(expectedRegistrationNumber, vehicle.RegistrationNumber);
            Assert.Equal(expectedColor, vehicle.Color);
        }


    }
}