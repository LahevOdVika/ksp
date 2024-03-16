//StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamReader sr = new StreamReader("C:\\Users\\Lahev\\Desktop\\ksp\\36-4\\snehulaci\\05.txt");
StreamWriter sw = new StreamWriter("C:\\Users\\Lahev\\Desktop\\ksp\\36-4\\snehulaci\\vystup.txt");
//StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int N = Convert.ToInt32(sr.ReadLine());

string s = sr.ReadLine().TrimEnd();
long[] koule = Array.ConvertAll(s.Split(' '), a => long.Parse(a));
Array.Sort(koule);

int pocet = 0;
List<string> snehulaci = new List<string>();

for (int i = koule.Length - 1; i >= 0; i-=3)
{
    if (i-2 >= 0)
    {
        pocet++;
        snehulaci.Add($"{koule[i]} {koule[i - 1]} {koule[i - 2]}");
    }
}
sw.WriteLine(pocet);
Console.WriteLine(pocet);
foreach (var t in snehulaci)
{
    sw.WriteLine(t);
    Console.WriteLine(t);
}
sw.Flush();