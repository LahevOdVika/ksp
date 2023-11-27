StreamReader sr = new StreamReader("C:/Users/Lahev/Documents/ksp/dopis/dopis/dopis.txt");

string puvodni = sr.ReadLine();
int n = Convert.ToInt32(sr.ReadLine());

for (int i = 0; i < n; i++)
{
    string nalezeny = sr.ReadLine();
    int x = 0;  //puvodní
    int y = 0;  //nalezený

    if (nalezeny.Length <= puvodni.Length)
    {
        for (int j = 0; j < nalezeny.Length;)
        {
            if (x < puvodni.Length)
            {
                if (nalezeny[y] == puvodni[x])
                {
                    x++;
                    y++;
                    j++;
                }
                else
                {
                    x++;
                }
            }
            else
            {
                break;
            }
        }   
    }

    if (y == nalezeny.Length)
    {
        Console.WriteLine("ANO");
    }
    else
    {
        Console.WriteLine("NE");
    }
}