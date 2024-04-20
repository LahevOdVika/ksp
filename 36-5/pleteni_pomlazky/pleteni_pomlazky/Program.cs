StreamReader sr = new StreamReader(@"C:\Users\Lahev\RiderProjects\pleteni_pomlazky\04.in");
StreamWriter sw = new StreamWriter(@"C:\Users\Lahev\RiderProjects\pleteni_pomlazky\vystup.txt");

/*
StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
*/

string[] radek = sr.ReadLine().Split(' ');

long K = Convert.ToInt32(radek[0]); // počet proutků
long N = Convert.ToInt64(radek[1]); // počet kroků
int X = Convert.ToInt32(radek[2]); // počáteční pozice

int[] kroky = sr.ReadLine().Split(' ').Select(digit => int.Parse(digit.ToString())).ToArray();
int[] pomlazka = new int[K];
for (int i = 0; i < K; i++)
{
    pomlazka[i] = i;
}
int[] tempPomlazka = new int[K];

for (long i = 0; i < N; i++)
{
    for (long j = 0; j < K; j++)
    {
        long krok = kroky[j];
        tempPomlazka[krok] = pomlazka[j];
    }

    (pomlazka, tempPomlazka) = (tempPomlazka, pomlazka);

    if (pomlazka[X] == X)
    {
        N %= i + 1;
        i = -1;
    }

    if (i % 100000 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine(pomlazka.ToList().IndexOf(X));
sw.WriteLine(pomlazka.ToList().IndexOf(X));
sw.Flush();