using SonarSweep.Domain;

namespace SonarSweep.Application
{
    public class SubmarineQueryService : QueryService
    {
        public override int CalculateMeasurementIncreases(Submarine submarine)
        {
            List<int> readings = submarine.ExtractSonarReadings().ToList();

            if (readings.Count == 0)
            {
                return 0;
            }

            return Enumerable.Range(1, readings.Count - 1)
                .Where(i => readings.ElementAt(i) > readings.ElementAt(i - 1))
                .Count();
        }

        public int CalculateWindowMeasurementIncreases(Submarine submarine)
        {
            int windowSize = 3;

            List<int> readings = submarine.ExtractSonarReadings().ToList();

            if (readings.Count <= windowSize)
            {
                return 0;
            }

            return Enumerable.Range(1, readings.Count - windowSize)
                .Where(i => readings.GetRange(i, windowSize).Sum() > readings.GetRange(i - 1, windowSize).Sum())
                .Count();
        }
    }
}
