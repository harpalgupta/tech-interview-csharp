using Vehicles.Api.Repositories;

namespace Vehicles.Api.Tests
{
    [TestClass]
    public class VehiclesRepositoryTests
    {
        private VehiclesRepository vehiclesRepository;

        [TestInitialize]
        public void init()
        {
            vehiclesRepository = new VehiclesRepository();
        }

        [TestMethod]
        public void WhenCallingGetAll_ExpectNoException()
        {
            var result = vehiclesRepository.GetAll();
        }
    }
}