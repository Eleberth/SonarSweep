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

            submarineCommandService.SweepSeaFloor(submarine);
            int increases = SubmarineQueryService.CalculateMeasurementIncreases(submarine);

            Assert.AreEqual(0, increases);
        }

        [TestMethod]
        public void ReadingsW10IncreasesShouldReturn10()
        {
            Submarine submarine = new();
            Submarine10IncreasesCommandService submarineCommandService = new();

            submarineCommandService.SweepSeaFloor(submarine);
            int increases = SubmarineQueryService.CalculateMeasurementIncreases(submarine);

            Assert.AreEqual(10, increases);
        }

        [TestMethod]
        public void ReadingsWSweepingShouldReturnMoreThanZero()
        {
            Submarine submarine = new();
            SubmarineCommandService submarineCommandService = new();

            submarineCommandService.SweepSeaFloor(submarine);
            int increases = SubmarineQueryService.CalculateMeasurementIncreases(submarine);

            Assert.IsTrue(increases > 0);
        }

        [TestMethod]
        public void ReadingsW3SweepsShouldReturnZeroForWindow()
        {
            Submarine submarine = new();
            Submarine3SweepsCommandService submarineCommandService = new();

            submarineCommandService.SweepSeaFloor(submarine);
            int increases = SubmarineQueryService.CalculateWindowMeasurementIncreases(submarine);

            Assert.AreEqual(0, increases);
        }

        [TestMethod]
        public void ReadingsW10IncreasesShouldReturn9ForWindow()
        {
            Submarine submarine = new();
            Submarine10IncreasesCommandService submarineCommandService = new();

            submarineCommandService.SweepSeaFloor(submarine);
            int increases = SubmarineQueryService.CalculateWindowMeasurementIncreases(submarine);

            Assert.AreEqual(9, increases);
        }

        [TestMethod]
        public void ReadingsWSweepingShouldReturnMoreThanZeroForWindow()
        {
            Submarine submarine = new();
            SubmarineCommandService submarineCommandService = new();

            submarineCommandService.SweepSeaFloor(submarine);
            int increases = SubmarineQueryService.CalculateWindowMeasurementIncreases(submarine);

            Assert.IsTrue(increases > 0);
        }
    }
}
