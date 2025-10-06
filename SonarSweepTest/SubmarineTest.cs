namespace SonarSweepTest
{
    using SonarSweep.Domain;
    using SonarSweep.Application;

    [TestClass]
    public sealed class SubmarineTest
    {
        [TestMethod]
        public void ReadingsWOSweepingShouldReturnZero()
        {
            Submarine submarine = new();

            IEnumerable<int> readings = submarine.ExtractSonarReadings();

            Assert.AreEqual(0, readings.Count());
        }

        [TestMethod]
        public void ReadingsWSweepingShouldReturnMoreThanZero()
        {
            Submarine submarine = new();
            SubmarineCommandService submarineCommandService = new();

            submarineCommandService.SweepSeaFloor(submarine);
            IEnumerable<int> readings = submarine.ExtractSonarReadings();

            Assert.IsTrue(readings.Any());
        }
    }
}
