using System;
using System.IO;


namespace _34_Z3_2_Teckovy_displej
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:/Users/Michal/OneDrive/Dokumenty/ksp/34_Z3_2_Teckovy_displej/ukazkovy_vstup.txt");

            string radek = sr.ReadLine();
            string[] hodnoty = radek.Split(" ");

            uint R = Convert.ToUInt32(hodnoty[0]); 
            uint S = Convert.ToUInt32(hodnoty[1]); 
            uint N = Convert.ToUInt32(hodnoty[2]); 
            uint M = Convert.ToUInt32(hodnoty[3]); 

            string NactiDisplej()
            {
                string vysledek = "";
                for (int i = 0; i < R; i++)
                {
                    string R1 = sr.ReadLine();
                    vysledek += R1;    
                }
                return vysledek;
            }

            string[] D = new string[N+M];
            for(int i = 0; i < N + M; i++)
            {
                D[i] = NactiDisplej();  

            }
            
            for(uint i = N; i < N + M; i++)
            {
                \
            }

        }
    }
}
