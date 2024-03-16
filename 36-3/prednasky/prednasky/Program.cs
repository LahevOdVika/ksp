namespace prednasky;

class Program
{
    private record Prednaska(long a, long b, char? c)
    {
        public long Zacatek = a;
        public long Konec = b;
        public char? Fakulta = c;
    }
    
    public static int Main(string[] args)
    {
        using StreamReader sr = new StreamReader("C:\\Users\\Lahev\\Desktop\\ksp\\36-3\\prednasky\\prednasky\\input");
        using StreamWriter sw = new StreamWriter("C:\\Users\\Lahev\\Desktop\\ksp\\36-3\\prednasky\\prednasky\\output");
        
        string[] radek = sr.ReadLine()!.Split(' ');

        long p = Convert.ToInt32(radek[0]);
        long n = Convert.ToInt32(radek[1]);

        var povinne = new Prednaska[p];
        var nepovinne = new Prednaska[n+1];

        long preskocene = 0;
        
        //Načítání vstupu
        for (long i = 0; i < p; i++)
        {
            radek = sr.ReadLine()!.Split(' ');
            povinne[i] = new Prednaska(Convert.ToInt32(radek[0]), Convert.ToInt32(radek[1]), radek[2][0]);
        }

        for (long i = 0; i < n; i++)
        {
            radek = sr.ReadLine()!.Split(' ');
            nepovinne[i] = new Prednaska(Convert.ToInt32(radek[0]), Convert.ToInt32(radek[1]), null);
        }

        nepovinne[n] = new Prednaska(Int32.MaxValue, Int32.MaxValue, null);
        
        for (long i = 0; i < p-1; i++)
        {
            var aktualni = povinne[i];
            var dalsi = povinne[i + 1];

            //Zjišťování jestli je další přednáška a jiné fakultě
            if (aktualni.Fakulta != dalsi.Fakulta)
            {
                Console.WriteLine("Číslo přednášky je {0}, začátek je {1} a konec je {2}", i, aktualni.Zacatek, aktualni.Konec);
                Console.WriteLine("Číslo přednášky je {0}, začátek je {1} a konec je {2}", i+1, dalsi.Zacatek, dalsi.Konec);
                
                long rekord = Int32.MaxValue;
                long a = 0;
                
                while (nepovinne[a].Zacatek < aktualni.Konec)
                {
                    a++;
                }

                long z = a - 1;

                long konecPrejezdu = aktualni.Konec + 40;

                while (true)
                {
                    while (nepovinne[a].Zacatek < konecPrejezdu && nepovinne[a].Konec <= dalsi.Zacatek)
                    {
                        a++;
                    }

                    if (a - z - 1 < rekord)
                    {
                        rekord = a - z - 1;
                    }

                    z++;
                    
                    if (z < nepovinne.Length)
                    {
                        konecPrejezdu = nepovinne[z].Konec + 40;   
                    }
                    
                    if (konecPrejezdu > dalsi.Zacatek)
                    {
                        preskocene += rekord;
                        break;
                    }
                }
            } 
        }
        Console.WriteLine(n - preskocene);
        sw.WriteLine(n - preskocene);
        sw.Flush();
        return 0;
    }
}
