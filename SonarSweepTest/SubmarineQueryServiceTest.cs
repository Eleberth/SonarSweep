using SonarSweep.Application;
using SonarSweep.Domain;

namespace SonarSweepTest
{
    [TestClass]
    public class SubmarineQueryServiceTest
    {
        [TestMethod]
        public void ReadingsW1SweepShouldReturnZero()
        {
            Submarine submarine = new();
            Submarine1SweepCommandService submarineCommandService = new();
            SubmarineQueryService submarineQueryService = new();

            submarineCommandService.SweepSeaFloor(submarine);
            int increases = submarineQueryService.CalculateMeasurementIncreases(submarine);

            Assert.AreEqual(0, increases);
        }

        [TestMethod]
        public void ReadingsW10IncreasesShouldReturn10()
        {
            Submarine submarine = new();
            Submarine10IncreasesCommandService submarineCommandService = new();
            SubmarineQueryService submarineQueryService = new();

            submarineCommandService.SweepSeaFloor(submarine);
            int increases = submarineQueryService.CalculateMeasurementIncreases(submarine);

            Assert.AreEqual(10, increases);
        }

        [TestMethod]
        public void ReadingsWSweepingShouldReturnMoreThanZero()
        {
            Submarine submarine = new();
            SubmarineCommandService submarineCommandService = new();
            SubmarineQueryService submarineQueryService = new();

            submarineCommandService.SweepSeaFloor(submarine);
            int increases = submarineQueryService.CalculateMeasurementIncreases(submarine);

            Assert.IsTrue(increases > 0);
        }
    }
}
