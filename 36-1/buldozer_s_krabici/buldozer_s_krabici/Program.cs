namespace buldozer_s_krabici
{
    class Program
    {
        public static void Main(string[] args)
        {
            using StreamReader sr = new StreamReader("C:/Users/Lahev/Documents/ksp/buldozer_s_krabici/buldozer_s_krabici/vstup.txt");
            using StreamWriter sw =
                new StreamWriter("C:/Users/Lahev/Documents/ksp/buldozer_s_krabici/buldozer_s_krabici/vystup.txt");
            var buldozer = sr.ReadLine();
            var krabice = sr.ReadLine();
            string kroky = sr.ReadLine();

            var xB = Convert.ToInt32(buldozer.Split(" ")[0]);
            var yB = Convert.ToInt32(buldozer.Split(" ")[1]);
            
            var xK = Convert.ToInt32(krabice.Split(" ")[0]);
            var yK = Convert.ToInt32(krabice.Split(" ")[1]);

            for (int i = 0; i < kroky.Length; i++)
            {
                switch (kroky[i])
                {
                    case 'N':
                        yB++;
                        if (yB == yK && xB == xK)
                            yK++;
                        break;
                    case 'P':
                        xB++;
                        if (xB == xK && yB == yK)
                            xK++;
                        break;
                    case 'L':
                        xB--;
                        if (xB == xK && yB == yK)
                            xK--;
                        break;
                    case 'D':
                        yB--;
                        if (yB == yK && xB == xK)
                            yK--;
                        break;
                }
            }
            sw.WriteLine($"{xB} {yB}");
            sw.WriteLine($"{xK} {yK}");
            sw.Flush();
        }
    }
}