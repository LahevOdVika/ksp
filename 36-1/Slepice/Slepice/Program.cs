namespace Slepice
{
    class Program
    {
        public static void Main(string[] args)
        {
            using StreamReader sr = new StreamReader("C:/Users/Lahev/Documents/ksp/Slepice/Slepice/05.in");
            using StreamWriter sw = new StreamWriter("C:/Users/Lahev/Documents/ksp/Slepice/Slepice/vystup.txt");

            var cisla = sr.ReadLine().Split(" ");

            var K = Convert.ToInt64(cisla[0]);  //Doba líhnutí vajec
            var P = Convert.ToInt64(cisla[1]);  //Perioda snášení vajec
            var D = Convert.ToInt64(cisla[2]);  //Kdy chce Kevin vědět odpověď
            
            long slepic = 0;
            long[] dny = new long[500000];
            dny[K-1]++;
            
            for (int i = 1; i < D; i++)
            {
                if (dny[i] > 0)
                {
                    slepic += dny[i];
                    var den = i + K + P;
                    
                    while (D > den)
                    {
                        dny[den] += dny[i];
                        den += P;
                    }
                }
                
            }
            Console.WriteLine(slepic);

            sw.WriteLine(slepic);
            sw.Flush();
        }
    }
}


