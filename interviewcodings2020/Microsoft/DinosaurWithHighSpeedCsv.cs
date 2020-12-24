using codekata.core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewcodings2020.Microsoft
{
    /// <summary>
    /// https://github.com/om-ganesh/codekata/issues/47
    /// </summary>
    class DinosaurWithHighSpeedCsv: IProblem
    {
        public void Execute()
        {
            // Read the raw files
            var projectPath =  Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            FileUtility fileUtility = new FileUtility(projectPath, @"Microsoft\data");
            var data1 = fileUtility.GetAllLines("dataset1.csv", true);
            var data2 = fileUtility.GetAllLines("dataset2.csv", true);

            // Read the input dinosaurs, maintain a dictionary of dinosaur with name as key, and object as value
            Dictionary<string, Dinosaur> dinosaurs = new Dictionary<string, Dinosaur>();
            foreach(var line in data1)
            {
                var item = line.Split(',');
                // Only add those dinosaurs that has valid leg length
                if(item.Length>=2 && Double.TryParse(item[1],out double result))
                {
                    Dinosaur dinosaur = new Dinosaur(item[0], result, item.Length > 2 ? item[2] : string.Empty);
                    if(!dinosaurs.ContainsKey(item[0]))
                    {
                        dinosaurs.Add(item[0], dinosaur);
                    }
                }
            }

            // Add further propety to dinasours from another file
            foreach (var line in data2)
            {
                var item = line.Split(',');
                //Search for our dinosaur in the list and update the other required properties
                if(item.Length>0 && dinosaurs.TryGetValue(item[0], out Dinosaur dino))
                {
                    if (item.Length >= 2 && Double.TryParse(item[1], out double result))
                    {
                        dino.StrideLength = result;
                        dino.Stance = item.Length >= 3 ? item[2] : string.Empty;
                    }
                }
            }

            // Filter out invalid dinosaurs and do calculation of speed
            // Also stored the good dinosaurs in the sorted list
            SortedList<double, Dinosaur> dinosaurList = new SortedList<double, Dinosaur>();
            foreach(var dinosaurKvp in dinosaurs)
            {
                if(dinosaurKvp.Value.StrideLength != 0 && dinosaurKvp.Value.LegLength != 0)
                {
                    //((STRIDE_LENGTH / LEG_LENGTH) - 1) * SQRT(LEG_LENGTH * g)
                    dinosaurKvp.Value.Speed = ((dinosaurKvp.Value.StrideLength / dinosaurKvp.Value.LegLength) - 1) * Math.Sqrt(dinosaurKvp.Value.LegLength * Constants.GRAVITY);
                    dinosaurList.Add(dinosaurKvp.Value.Speed, dinosaurKvp.Value);
                }
            }

            // Sort the dinosaurs by speed ascending order
            //foreach(var dinosaurItem in dinosaurList)
            //{
            //    if(Constants.BIPEDAL.Equals(dinosaurItem.Value.Stance, StringComparison.InvariantCultureIgnoreCase))
            //    {
            //        Console.WriteLine($"{dinosaurItem.Value.Name} with speed {dinosaurItem.Value.Speed}");
            //    }
            //}

            for(int i = dinosaurList.Count-1; i>=0; i--)
            {
                if (Constants.BIPEDAL.Equals(dinosaurList.Values[i].Stance, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"{dinosaurList.Values[i].Name} with speed {dinosaurList.Keys[i]}");
                }
            }
        }
    }

    class Dinosaur : IComparable<Dinosaur>
    {
        public string Name { get; set; }
        public double LegLength { get; set; }
        public double StrideLength { get; set; }
        public string Stance { get; set; }
        public string Diet { get; set; }
        public double Speed { get; set; }

        public Dinosaur(string name, double leg, string diet)
        {
            this.Name = name;
            this.LegLength = leg;
            this.Diet = diet;
        }

        public Dinosaur(string name, double leg, double stride, string stance, string diet)
        {
            Name = name;
            LegLength = leg;
            StrideLength = stride;
            Stance = stance;
            Diet = diet;
        }

        public void CalculateSpeed(bool displayInConsole = false)
        {
            // speed = ((STRIDE_LENGTH / LEG_LENGTH) - 1) * SQRT(LEG_LENGTH * g)
            this.Speed = ((StrideLength / LegLength) - 1) * Math.Sqrt(LegLength * Constants.GRAVITY);
            if (displayInConsole)
            {
                Console.WriteLine($"Speed for {this.Name} is {this.Speed}");
            }
        }

        /// <summary>
        /// Value Meaning Less than zero: This instance precedes other in the sort order.
        /// Zero: This instance occurs in the same position in the sort order as other.
        /// Greater than zero: This instance follows other in the sort order.
        /// </summary>
        public int CompareTo(Dinosaur other)
        {
            return Speed.CompareTo(other.Speed);
        }
    }


    class Constants
    {
        public static double GRAVITY = 9.8; //unit in m/s^2
        public static string BIPEDAL = "bipedal"; 
    }
}
