namespace SonarSweep.Domain
{
    public class Sonar
    {
        private IEnumerable<int>? Readings { get; set; }

        public void SweepSeaFloor(IEnumerable<int> readings)
        {
            Readings = readings;
        }

        public IEnumerable<int> ExtractReadings()
        {
            return Readings ?? [];
        }
    }
}
