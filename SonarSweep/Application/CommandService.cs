using SonarSweep.Domain;

namespace SonarSweep.Application
{
    public abstract class CommandService
    {
        abstract public void SweepSeaFloor(Submarine submarine);
    }
}
