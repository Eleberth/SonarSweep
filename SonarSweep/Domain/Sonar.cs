namespace SonarSweep.Domain
{
    public class Sonar
    {
        private List<int>? Readings { get; set; }

        public void SweepSeaFloor(List<int> readings)
        {
            Readings = readings;
        }

        public List<int> ExtractReadings()
        {
            return Readings ?? [];
        }
    }
}
