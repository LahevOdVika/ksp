using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sankovani
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("Z:/vstup.txt");
            StreamWriter sw = new StreamWriter("Z:/vystup.txt");

            int N = Convert.ToInt32(sr.ReadLine());

            int[] vrcholy = Array.ConvertAll(sr.ReadLine().Split(' '), s => int.Parse(s));

            int stoupani = 0;

            int rychlost = 0;

            for (int i = 0; i < vrcholy.Length-1; i++)
            {
                if (vrcholy[i] > vrcholy[i+1])
                {
                    rychlost = vrcholy[i] - vrcholy[i + 1];
                } else if (vrcholy[i] + rychlost >= vrcholy[i+1])
                {
                    rychlost = vrcholy[i] + rychlost - vrcholy[i + 1];
                } else
                {
                    rychlost = 0;
                    stoupani += vrcholy[i + 1] - vrcholy[i];
                }
            }

            sw.WriteLine(stoupani);
            sw.Flush();
        }
    }
}
