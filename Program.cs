using System;

namespace SonarSweepFirstPart
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\j.gullung\source\repos\SonarSweepFirstPart\input.txt");
            int[] depths = Array.ConvertAll(lines, s => int.Parse(s));
            int previousDepth = depths[0];
            int increases = 0;

            for (int i = 0; i < depths.Length; i++)
            {
                if (previousDepth < depths[i])
                {
                    increases++;
                }
                previousDepth = depths[i];
            }
            Console.WriteLine(increases);
        }
    }
}
