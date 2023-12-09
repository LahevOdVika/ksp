StreamReader sr = new StreamReader("C:/Users/Lahev/Desktop/ksp/36-2/obed_v_tovarne/obed_v_tovarne/06.in");
StreamWriter sw = new StreamWriter("C:/Users/Lahev/Desktop/ksp/36-2/obed_v_tovarne/obed_v_tovarne/vysledek.out");

string[] vstup = sr.ReadLine().Split(' ');

//Proměnné
int radky = Convert.ToInt32(vstup[0]);
int sloupce = Convert.ToInt32(vstup[1]);
int x = Convert.ToInt32(vstup[2]);
int y = Convert.ToInt32(vstup[3]);

//2D pole
char[,] pas = new char[radky, sloupce];

//Načtení hodnot do pole
for (int r = 0; r < radky; r++)
{
    char[] radek = sr.ReadLine().ToCharArray();
    for (int s = 0; s < sloupce; s++)
    {
        pas[r,s] = radek[s];
    }
}

for (int i = 0; i < pas.Length; i++)
{
    switch (pas[y,x]) 
    {
        case '^':
            y--;
            break;
        case 'v':
            y++;
            break;
        case '<':
            x--;
            break;
        case '>':
            x++;
            break; 
    }
//    Console.WriteLine(x + " " + y);
    if (x >= sloupce)
    {
        x--;
        break;
    }

    if (x < 0)
    {
        x++;
        break;
    }

    if (y < 0)
    {
        y++;
        break;
    }

    if (y >= radky)
    {
        y--;
        break;
    }
}
sw.WriteLine(x + " " + y);
sw.Flush();