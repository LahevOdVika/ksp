using System.Text;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter("C:\\Users\\Lahev\\Documents\\output");

string[] radek = sr.ReadLine().Split(' ');

int w = Convert.ToInt32(radek[0]);
int h = Convert.ToInt32(radek[1]);

StringBuilder[] reka = new StringBuilder[h];

int[] cesta = new int[h];

for (int i = 0; i < h; i++)
{
    reka[i] =  new StringBuilder(sr.ReadLine());
}

void Zkontroluj(int width, int height)
{
    if (reka[height][width] != 'X')
    {
        reka[height][width] = 'X';
        cesta[height] =  width;
        
        if (height == reka.Length-1)
        {
            //Console.WriteLine(cesta.Join(" "0));
            sw.WriteLine(string.Join("\n", cesta.Select(x => x.ToString()).ToArray()));
            sw.Flush();
            Environment.Exit(0);
            //return;
        }

        if (width - 1 >= 0) Zkontroluj(width - 1, height + 1);
        Zkontroluj(width, height + 1);
        if (width+1 <= w-1) Zkontroluj(width + 1, height + 1);
        
    }
    
}


for (int i = 0; i < w; i++)
{
    Zkontroluj(i, 0);
}