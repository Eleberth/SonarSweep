namespace SonarSweep.Domain
{
    public class Submarine
    {
        public Submarine()
        {
            Sonar = new();
        }

        public Sonar Sonar { get; }
        public void SweepSeaFloor(IEnumerable<int> readings)
        {
            Sonar.SweepSeaFloor(readings);
        }

        public IEnumerable<int> ExtractSonarReadings()
        {
            return Sonar.ExtractReadings();
        }
    }
}
