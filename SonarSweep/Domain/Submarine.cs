namespace SonarSweep.Domain
{
    public class Submarine
    {
        public Submarine()
        {
            Sonar = new();
        }

        public Sonar Sonar { get; }
        public void SweepSeaFloor(List<int> readings)
        {
            Sonar.SweepSeaFloor(readings);
        }

        public List<int> ExtractSonarReadings()
        {
            return Sonar.ExtractReadings();
        }
    }
}
