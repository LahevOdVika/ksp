using System.Numerics;
using System.Text;
using static Naledi.Vector;
using Vector = Naledi.Vector;

var sr = new StreamReader("C:\\Users\\Lahev\\Desktop\\ksp\\36-4\\Naledi\\Naledi\\test.txt");
var sw = new StreamWriter("C:\\Users\\Lahev\\Desktop\\ksp\\36-4\\Naledi\\Naledi\\vystup.txt");

var radek = sr.ReadLine();

var H = Convert.ToInt32(radek.Split(" ")[0]);
var W = Convert.ToInt32(radek.Split(" ")[1]);

StringBuilder[] kluziste = new StringBuilder[H];

for (var i = 0; i < H; i++)
{
    kluziste[i] = new StringBuilder(sr.ReadLine());
}

void Zkus(Vector pozice, Vector smer, char smerPismeno, string cesta)
{
    while (pozice.jeVPoli(H, W) && (kluziste[pozice.x][pozice.y] == '.' || kluziste[pozice.x][pozice.y] == 'S'))
    {
        pozice.prictiVektor(smer);
    }

    if (kluziste[pozice.x][pozice.y] == 'S')
    {
        Console.WriteLine(cesta);
        sw.WriteLine(cesta);
        sw.Flush();
        return;
    }

    cesta += smerPismeno;

    if (pozice.x + 1 <= W-1)
    {
        Zkus(pozice, new Vector(1,0), 'P', cesta);
    }

    if (pozice.y + 1 <= H-1)
    {
        Zkus(pozice, new Vector(0,1), 'D', cesta);
    }

    if (pozice.x - 1 > 0)
    {
        Zkus(pozice, new Vector(-1,0), 'L', cesta);
    }

    if (pozice.y - 1 > 0)
    {
        Zkus(pozice, new Vector(0,-1), 'N', cesta);
    }

}

Zkus(new Vector(0,0), new Vector(1,0), 'P', "");
Zkus(new Vector(0,0), new Vector(0,1), 'D', "");
Zkus(new Vector(0,0), new Vector(-1,0), 'L', "");
Zkus(new Vector(0,0), new Vector(0,-1), 'N', "");