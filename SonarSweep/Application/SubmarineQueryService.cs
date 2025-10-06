using SonarSweep.Domain;

namespace SonarSweep.Application
{
    public class SubmarineQueryService : QueryService
    {
        public override int CalculateMeasurementIncreases(Submarine submarine)
        {
            IEnumerable<int> readings = submarine.ExtractSonarReadings();

            if (!readings.Any())
            {
                return 0;
            }

            return Enumerable.Range(1, readings.Count() - 1)
                .Where(i => readings.ElementAt(i) > readings.ElementAt(i - 1))
                .Count();
        }
    }
}
