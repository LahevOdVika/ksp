using System;
using System.IO;
namespace ksp_z_34_2_3_skladani_krabic
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/Michal/Documents/ksp/ksp_z_34_2_3/ksp_z_34_2_3_skladani_krabic/06.in"))
            {

                uint N = Convert.ToUInt32(sr.ReadLine());
                uint[] krabice = new uint[N];
                uint[] delka = new uint[N];
                uint max = 0;

                for (int i = 0; i < N; i++)
                {
                    krabice[i] = Convert.ToUInt32(sr.ReadLine());
                    delka[i] = 1;
                    
                    for(uint j = 0; j < i; j++)
                    {
                        if (krabice[j] < krabice[i])
                        {
                            delka[i] = Math.Max(delka[i], delka[j]+1) ;                      
                        }
                    }
                   
                }
                for (int i = 0; i < N; i++)
                {
                    if(max < delka[i])
                    {
                        max = delka[i];
                    }
                }

                Console.WriteLine(max);
                using (StreamWriter vystup = new StreamWriter("C:/Users/Michal/Documents/ksp/ksp_z_34_2_3/ksp_z_34_2_3_skladani_krabic/vystup.txt"))
                {
                    
                    vystup.WriteLine(max);
                    vystup.Flush();
                }
            }
             
            
        }
    }
}
