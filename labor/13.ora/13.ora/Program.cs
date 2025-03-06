using System;
using System.Collections.Generic;
using System.IO;

namespace ora13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> lines = new List<string>();
            try
            {
                Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory());
                using (StreamReader reader = new StreamReader("input.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(string.Join(", ", lines));

            List<int> groupA = new List<int>();
            List<int> groupB = new List<int>();

            foreach (string line in lines)
            {
                string[] parts = line.Split("   ");
                groupA.Add(Int32.Parse(parts[0]));
                groupB.Add(Int32.Parse(parts[1]));
            }
          
            Console.WriteLine(string.Join (", ", groupA));
            Console.WriteLine(string.Join (", ", groupB));

            
            using(StreamWriter write = new StreamWriter("output.txt"))
            {
                write.WriteLine($"The total distance is:{SolvePartOne(groupA,groupB)}");
                write.WriteLine($"The result is: {SolvePartTwo(groupA, groupB)}");
            }

        }
        private static int SolvePartOne(List<int> groupA, List<int> groupB)
        {

            int totalDistance = 0;

            for (int i = 0; i < groupA.Count; i++)
            {
                totalDistance += Math.Abs(groupA[i] - groupB[i]);
            }
            return totalDistance;
        }


        private static int SolvePartTwo(List<int> groupA,List<int> groupB)
        {
            int res = 0,count;

            foreach (int idToSearch in groupA)
            {
                count = 0;
                foreach (var id in groupB)
                {
                    if (idToSearch == id)
                        count++;
                }
            }
            return res;
        }

    }
}
