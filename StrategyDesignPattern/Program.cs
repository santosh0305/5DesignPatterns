using StrategyPattern.Implementation;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            var reports = new List<DeveloperReport>
            {
                new DeveloperReport { Id = 1, Name = "Developer4", Level = "Junior", HourlyRate = 20.5, WorkingHours = 130 },
                new DeveloperReport { Id = 2, Name = "Developer1", Level = "Junior", HourlyRate = 30, WorkingHours = 110 },
                new DeveloperReport { Id = 3, Name = "Developer3", Level = "Senior", HourlyRate = 32.5, WorkingHours = 180 },
                new DeveloperReport { Id = 3, Name = "Developer2", Level = "SuperSenior", HourlyRate = 32.5, WorkingHours = 140 },
            };

            // Create StrategyContext 'context' object for calling CommonMethod i.e. 
            var context = new StrategyContext(new Strategy1());

            var juniorTotal = context.CommonStrategyEntry(reports);

            context.SetContext(new Strategy2());
            var seniorTotal = context.CommonStrategyEntry(reports);

            context.SetContext(new Strategy3());
            var superSeniorTotal = context.CommonStrategyEntry(reports);

            Console.WriteLine($"Total amount for junior salaries is: {juniorTotal}");
            Console.WriteLine($"Total amount for senior salaries is: {seniorTotal}");
            Console.WriteLine($"Total amount for senior salaries is: {superSeniorTotal}");
            Console.WriteLine($"Total cost for all the salaries is: {juniorTotal + seniorTotal + superSeniorTotal}");

            Console.ReadLine();
        }
    }
}
