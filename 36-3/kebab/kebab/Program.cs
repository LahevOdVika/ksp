StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

string[] radek = sr.ReadLine().Split(" ");
int pocetObchodu = Convert.ToInt32(radek[0]);
int cenaKm = Convert.ToInt32(radek[1]);
int nejmensiCena = int.MaxValue;

for (int i = 0; i < pocetObchodu; i++)
{
    string[] obchod = sr.ReadLine().Split(" ");
    int cenaKebab = Convert.ToInt32(obchod[0]);
    int cenaVzdalenost = Convert.ToInt32(obchod[1]) * cenaKm;

    int cenaCelkem = cenaKebab + cenaVzdalenost;
    
    if (cenaCelkem < nejmensiCena)
    {
        nejmensiCena = cenaCelkem;
    }
}
sw.WriteLine();