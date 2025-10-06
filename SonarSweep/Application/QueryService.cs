using SonarSweep.Domain;

namespace SonarSweep.Application
{
    public abstract class QueryService
    {
        abstract public int CalculateMeasurementIncreases(Submarine submarine);
    }
}
