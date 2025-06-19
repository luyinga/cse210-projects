using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exerciseList = new List<Exercise>();

        Running running = new Running("June 19, 2025", 35, 5.8);
        exerciseList.Add(running);

        StationaryBicycles stationaryBicycles = new StationaryBicycles("June 22, 2025", 50, 20);
        exerciseList.Add(stationaryBicycles);

        Swimming swimming = new Swimming("June 24, 2025", 26, 26);
        exerciseList.Add(swimming);

        Console.WriteLine("Exercises:");
        Console.WriteLine();

        foreach (Exercise exercise in exerciseList)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}