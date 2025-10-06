using SonarSweep.Application;
using SonarSweep.Domain;

Submarine submarine = new();
SubmarineCommandService commandService = new();

commandService.SweepSeaFloor(submarine);

Console.WriteLine("Number of measurement increases:");
Console.WriteLine(SubmarineQueryService.CalculateMeasurementIncreases(submarine));

Console.WriteLine("Number of measurement increases with window:");
Console.WriteLine(SubmarineQueryService.CalculateWindowMeasurementIncreases(submarine));
