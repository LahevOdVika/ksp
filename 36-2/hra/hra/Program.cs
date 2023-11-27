using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace hra
{
    public class Recept
    {
        public int Predmet { get; set; }
        public string Ingredience { get; set; } 
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("/home/lahev/ksp/ksp/36-2/hra/hra/05.in");
            StreamWriter sw = new StreamWriter("/home/lahev/ksp/ksp/36-2/hra/hra/vystup.txt");
            
            //Počet receptů
            int M = Convert.ToInt32(sr.ReadLine().Split(' ')[1]);

            int[] ceny = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            List<Recept> recepty = new List<Recept>();
            
            //Přidání do pole a seřazení
            for (int i = 0; i < M; i++)
            {
                Recept recept = new Recept();
                recept.Predmet = Convert.ToInt32(sr.ReadLine().Split(' ')[0]);
                recept.Ingredience = sr.ReadLine();
                recepty.Add(recept);
            }
            //Sortovat podle čísla
            recepty.Sort(delegate(Recept c1, Recept c2) { return c1.Predmet.CompareTo(c2.Predmet); });

            //Zjišťování cen
            for (int i = recepty.Count - 1; i >= 0; i--)
            {
                int predmet = recepty[i].Predmet;
                string[] ingredience = recepty[i].Ingredience.Split(' ');
                int cena = 0;
                
                for (int j = 0; j < ingredience.Length; j++)
                {
                    cena += ceny[Convert.ToInt32(ingredience[j])];
                }

                if (cena < ceny[predmet]) ceny[predmet] = cena;
            }
            Console.WriteLine(ceny[0]);
            
            sw.WriteLine(ceny[0]);
            sw.Flush();
        }
    }
}