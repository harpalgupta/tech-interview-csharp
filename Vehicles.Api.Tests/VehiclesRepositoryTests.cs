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
        public void WhenCallingGetAll_ExpectNonEmptyList()
        {
            var result = vehiclesRepository.GetAll();
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        [ExpectedException(typeof (FileNotFoundException))]
        public void GivenWrongPathWhenCallingGetAll_Throws()
        {
            vehiclesRepository = new VehiclesRepository("blahPath");
        }
    }
}