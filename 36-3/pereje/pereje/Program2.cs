StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

string[] radek = sr.ReadLine().Split(' ');

int w = Convert.ToInt32(radek[0]);
int h = Convert.ToInt32(radek[1]);

string[] reka = new string[h];

for (int i = 0; i < h; i++)
{
    reka[i] = sr.ReadLine();
}

void Zkontroluj(int width, int height, string cesta)
{
    
    if (reka[height][width] != 'X')
    {
        cesta += String.Format("{0} ", width);
        
        if (height == reka.Length-1)
        {
            Console.WriteLine(cesta);
            //Environment.Exit(0);
            return;
        }

        if (width - 1 >= 0) Zkontroluj(width - 1, height + 1, cesta);
        Zkontroluj(width, height + 1, cesta);
        if (width+1 <= w-1) Zkontroluj(width + 1, height + 1, cesta);
        
    }
}

for (int i = 0; i < w; i++)
{
   Zkontroluj(i, 0, "");
}