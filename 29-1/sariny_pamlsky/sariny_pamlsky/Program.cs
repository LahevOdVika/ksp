StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

string[] vstup = sr.ReadLine().Split(" ");
int zacatek = Convert.ToInt32(vstup[0]);
int konec = Convert.ToInt32(vstup[1]);

for (int i = zacatek; i < konec; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(); 
    } else if (i % 3 == 0)
    {
        Console.WriteLine("#");
    } else if (i % 5 == 0)
    {
        Console.WriteLine("O");
    } else
    {
        Console.WriteLine(i);    
    }
}

