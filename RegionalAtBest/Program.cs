using System;
using System.IO;

namespace RegionalAtBest
{
    class Program
    {
        static void Main(string[] args)
        {
            using var sr = new StreamReader(Path.Combine(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\")), "input.txt"));
            RegionManager regionManager = new RegionManager(sr.ReadLine());
            regionManager.PrintRegionOption();
        }
    }
}
