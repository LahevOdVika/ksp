namespace Sankovani
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int N = Convert.ToInt32(sr.ReadLine());

            int[] vrcholy = Array.ConvertAll(sr.ReadLine().Split(' '), s => int.Parse(s));

            int stoupani = 0;

            int rychlost = 0;

            for (int i = 0; i < vrcholy.Length-1; i++)
            {
                if (vrcholy[i] >vrcholy[i+1])
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