using SonarSweep.Domain;

namespace SonarSweep.Application
{
    internal class Submarine1SweepCommandService : CommandService
    {
        public override void SweepSeaFloor(Submarine submarine)
        {
            #region Sweep
            List<int> readings =
            [
                143
            ];
            #endregion

            submarine.SweepSeaFloor(readings);
        }
    }

    internal class Submarine10IncreasesCommandService : CommandService
    {
        public override void SweepSeaFloor(Submarine submarine)
        {
            #region Sweep
            List<int> readings =
            [
                5,
                10,
                5,
                10,
                5,
                10,
                5,
                10,
                5,
                10,
                5,
                10,
                5,
                10,
                5,
                10,
                5,
                10,
                5,
                10
            ];
            #endregion

            submarine.SweepSeaFloor(readings);
        }
    }
}
