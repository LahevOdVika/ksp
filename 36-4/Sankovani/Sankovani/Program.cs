namespace Sankovani
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\Users\\Lahev\\Desktop\\ksp\\36-4\\Sankovani\\05.in");
            StreamWriter sw = new StreamWriter("C:\\Users\\Lahev\\Desktop\\ksp\\36-4\\Sankovani\\vystup.txt");

            int N = Convert.ToInt32(sr.ReadLine());

            int[] vrcholy = Array.ConvertAll(sr.ReadLine().Trim().Split(' '), s => int.Parse(s));

            int stoupani = 0;

            int rychlost = 0;

            int trasa = 0;
            
            for (int i = 0; i < vrcholy.Length-1; i++)
            {
                trasa = vrcholy[i] - vrcholy[i + 1];
                switch (trasa)
                {
                    case >=0:
                        rychlost += trasa;
                        break;
                    case <0:
                        if (trasa + rychlost >= 0)
                        {
                            rychlost += trasa;
                        }
                        else
                        {
                            rychlost = 0;
                            stoupani += Math.Abs(trasa);
                        }
                        break;
                }
            }
            
            sw.WriteLine(stoupani);
            sw.Flush();
        }
    }
}