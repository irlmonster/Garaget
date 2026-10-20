using Ovning_5_Garaget.Vehicles;

namespace Ovning_5_Garaget.Tests
{
    public class VehicleTests
    {
        [Fact] // kolla så det kastar på invalid regnummer
        public void Constructor_InvalidRegNumber_Throws()
        {
            Assert.Throws<ArgumentException>(() => new Car("123ABC", "Röd", 4, "Volvo", "Bensin", CarType.Kombi));
        }


        [Fact]
        public void Constructor_LowercaseWithSpaces_NormalizesRegNumber()
        {
            // Arrange + Act: konstruktorn är det vi testar, så att skapa bilen är själva "görandet"
            var car = new Car("  abc123  ", "Röd", 4, "Volvo", "Bensin", CarType.Kombi);

            // Assert: förväntat värde först, faktiskt värde sist
            Assert.Equal("ABC123", car.RegNumber);
        }

    }
}
