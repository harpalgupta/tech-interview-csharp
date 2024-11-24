using Moq;
using Vehicles.Api.Models;
using Vehicles.Api.Repositories;
using Vehicles.Api.Services;

namespace Vehicles.Api.Tests
{
    [TestClass]
    public class VehiclesServiceTests
    {
        private Mock<IVehiclesRepository> mockVehicleRepo = new Mock<IVehiclesRepository>();

        [TestMethod]
        public void GetAllVehiclesReturnsCorrectNumberOfVehicles()
        {
            //Arrange
            var listOfVehicles = new List<Vehicle>
            {
                new Vehicle { Make = "ford" },
                new Vehicle { Make = "ford" },
                new Vehicle { Make = "bmw" },
                new Vehicle { Make = "somethig" },
            };
            mockVehicleRepo.Setup(r => r.GetAll()).Returns(listOfVehicles);
            var vehicleService = new VehiclesService(mockVehicleRepo.Object);

            //Act
            var result = vehicleService.GetAllVehicles();

            //Assert

            Assert.AreEqual(listOfVehicles.Count, result.Count);

        }

        [TestMethod]
        public void GetByMakeReturnsCorrectNumberOfFilteredVehicles()
        {
            //Arrange
            var listOfVehicles = new List<Vehicle>
            {
                new Vehicle { Make = "ford" },
                new Vehicle { Make = "ford" },
                new Vehicle { Make = "bmw" }
            };
            mockVehicleRepo.Setup(r => r.GetAll()).Returns(listOfVehicles);
            var vehicleService = new VehiclesService(mockVehicleRepo.Object);

            //Act
            var result = vehicleService.GetByMake("ford");

            //Assert

            Assert.AreEqual(2,result.Count);

        }
        [TestMethod]
        public void GetByModelReturnsCorrectNumberOfFilteredVehicles()
        {
            //Arrange
            var listOfVehicles = new List<Vehicle>
            {
                new Vehicle { Model = "Fiesta" },
                new Vehicle { Model = "Fiesta" },
                new Vehicle { Model = "Siesta" }
            };
            mockVehicleRepo.Setup(r => r.GetAll()).Returns(listOfVehicles);
            var vehicleService = new VehiclesService(mockVehicleRepo.Object);

            //Act
            var result = vehicleService.GetByModel("Fiesta");

            //Assert

            Assert.AreEqual(2, result.Count);

        }

        [TestMethod]
        public void GivenOnlyToPrice_WhenCallingGetByPrice_GivesCorrectNumberOfFilteredVehicles()
        {
            //Arrange
            var listOfVehicles = new List<Vehicle>
            {
                new Vehicle { Price = 10},
                new Vehicle { Price = 20 },
                new Vehicle { Price = 30 }
            };
            mockVehicleRepo.Setup(r => r.GetAll()).Returns(listOfVehicles);
            var vehicleService = new VehiclesService(mockVehicleRepo.Object);

            //Act
            var result = vehicleService.GetByPrice(null,20);

            //Assert

            Assert.AreEqual(2, result.Count);

        }
        [TestMethod]
        public void GivenPriceRange_WhenCallingGetByPrice_GivesCorrectNumberOfFilteredVehicles()
        {
            //Arrange
            var listOfVehicles = new List<Vehicle>
            {
                new Vehicle { Price = 10},
                new Vehicle { Price = 20 },
                new Vehicle { Price = 30 },
                new Vehicle { Price = 40 },
                new Vehicle { Price = 50 }

            };
            mockVehicleRepo.Setup(r => r.GetAll()).Returns(listOfVehicles);
            var vehicleService = new VehiclesService(mockVehicleRepo.Object);

            //Act
            var result = vehicleService.GetByPrice(20, 50);

            //Assert

            Assert.AreEqual(4, result.Count);

        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GivenNoPriceRange_WhenCallingGetByPrice_Throws()
        {
            //Arrange
            var listOfVehicles = new List<Vehicle>
            {
                new Vehicle { Price = 10},
                new Vehicle { Price = 20 },
                new Vehicle { Price = 30 },
                new Vehicle { Price = 40 },
                new Vehicle { Price = 50 }

            };
            mockVehicleRepo.Setup(r => r.GetAll()).Returns(listOfVehicles);
            var vehicleService = new VehiclesService(mockVehicleRepo.Object);

            //Act
            var result = vehicleService.GetByPrice(null, null);

        }
    }
}
