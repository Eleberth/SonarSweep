using SonarSweep.Application;
using SonarSweep.Domain;

Submarine submarine = new();
SubmarineCommandService commandService = new();
SubmarineQueryService queryService = new();

commandService.SweepSeaFloor(submarine);

Console.WriteLine("Number of measurement increases:");
Console.WriteLine(queryService.CalculateMeasurementIncreases(submarine));

Console.WriteLine("Number of measurement increases with window:");
Console.WriteLine(queryService.CalculateWindowMeasurementIncreases(submarine));
