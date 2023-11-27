// Path: kevin_a_krtince/Program.cs
StreamReader sr = new StreamReader("C:/Users/Lahev/Documents/ksp/36-2/kevin_a_krtince/kevin_a_krtince/05.in");
StreamWriter sw = new StreamWriter("C:/Users/Lahev/Documents/ksp/36-2/kevin_a_krtince/kevin_a_krtince/out.out");

//Proměnné
int m = Convert.ToInt32(sr.ReadLine().Split(" ")[0])-1;
int kopani = 1;

//Načetní krtinců do pole
string[] krtince = sr.ReadLine().Split(" ");

int krtineczacatek = Convert.ToInt32(krtince[0]);
int krtinecaktualni=0;

//Hledání nejmenšího počtu použití motyky
for (int i = 1; i < krtince.Length; i++)
{
    krtinecaktualni = Convert.ToInt32(krtince[i]);
    if (krtinecaktualni > krtineczacatek + m)
    {
        kopani++;
        Console.WriteLine(krtineczacatek + "->"+krtinecaktualni);
        krtineczacatek = krtinecaktualni;
    }
}
Console.WriteLine(krtineczacatek + "->"+krtinecaktualni);
sw.WriteLine(kopani);
sw.Flush();