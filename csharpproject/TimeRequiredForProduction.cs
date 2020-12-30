using csharpproject.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    class TimeRequiredForProduction : IProblem
    {
        public void Execute()
        {
            List<(long[], long)> dataset = new List<(long[], long)>();
            dataset.Add((new long[] { 2, 3, 2 }, 10));//8
            dataset.Add((new long[] { 2, 3 }, 5));//6
            dataset.Add((new long[] { 1, 3, 4 }, 10));//7
            dataset.Add((new long[] { 4, 5, 6 }, 12));//20
            dataset.Add((new long[] { 63, 2, 26, 59, 16, 55, 99, 21, 98, 65 }, 56)); //answer = 82
            //machinetimeforproduction-1.txt 10000 machines with goal 1667 //ans: 154
            //machinetimeforproduction-2.txt 100000 machines with goal 477521 //ans: 2984

            //dataset.ForEach(data =>
            //{
            //    long ans = minTime(data.Item1, data.Item2);
            //    Console.WriteLine($"The machine {string.Join(",", data.Item1)} with goal {data.Item2} takes {ans} days");
            //});

            ExecuteFromFile();
        }

        public void ExecuteFromFile()
        {
            //var filePath = @"C:\ARepos\omganesh\codekata\csharpproject\data\machinetimeforproduction-1.txt";
            var dataIn = FileReader.GetAllLines("machinetimeforproduction-1.txt");

            string[] nGoal = dataIn[0].Split(' ');
            int n = Convert.ToInt32(nGoal[0]);
            long goal = Convert.ToInt64(nGoal[1]);

            long[] machines = Array.ConvertAll(dataIn[1].Split(' '), machinesTemp => Convert.ToInt64(machinesTemp));
            long ans = minTime(machines, goal);
            Console.WriteLine($"The answer is {ans} days");
        }

        //searching the best time and worst time and searching in between
        static long minTime(long[] machines, long goal)
        {
            // Find the fast (min value) and slow (max value) machines
            long fastRate = Int64.MaxValue;
            long slowRate = Int64.MinValue;
            for (int i = 0; i < machines.Length; i++)
            {
                if(machines[i] < fastRate)
                {
                    fastRate = machines[i];
                }
                if (machines[i] > slowRate)
                {
                    slowRate = machines[i];
                }
            }
            long minDaysRequired = goal < machines.Length ? fastRate : goal/machines.Length * fastRate;
            long maxDaysRequired = goal < machines.Length ? slowRate : goal / machines.Length * slowRate;
            return SearchMinimumDaysBetween(machines, goal, minDaysRequired, maxDaysRequired);
        }

        private static long SearchMinimumDaysBetween(long[] machines, long goal, long minDays, long maxDays)
        {
            while (minDays < maxDays)
            {
                long midDays = minDays + (maxDays - minDays) / 2;
                long totalWorkCompleted = 0;
                for (int i = 0; i < machines.Length; i++)
                {
                    // TODO 77 for double, and 84 for integer (expected ans:82)
                    totalWorkCompleted += midDays / machines[i];
                }
                if (totalWorkCompleted >= goal)
                {
                    maxDays = midDays;
                }
                else
                {
                    minDays = midDays + 1;
                }
            }
            return maxDays;
        }

        // Performance problem (Time Limit exceeded)
        static long minTime1(long[] machines, long goal)
        {
            int days = 0;
            int totalPerf = 0;

            // Create daily performance array
            long[] dailyPerf = new long[machines.Length];
            for(int i=0;i<machines.Length;i++)
            {
                dailyPerf[i] = machines[i];
            }
            
            while(totalPerf < goal)
            {
                for(int j=0;j<machines.Length;j++)
                {
                    // Machine done its performance and if results 0 then increase total, and reset particular machine value.
                    dailyPerf[j] = dailyPerf[j]-1;
                    if(dailyPerf[j] ==0)
                    {
                        totalPerf++;
                        dailyPerf[j] = machines[j];
                    }
                }
                days++;
            }
            return days;
        }
    }
}
