using System;
using System.IO;

namespace ksp_z_34_2_1_polivka
{ 
    
    class Program
    {
        static void Main(string[] args)
        {

            uint cas = 0;
            uint polivky = 0;

            using (StreamReader sr = new StreamReader("C:/Users/Michal/Documents/ksp/ksp_z_34_2_1_polivka/04.in"))
            {
                string[] rozdelene;
                uint oteviraci;
                uint zaviraci;
                
                rozdelene = sr.ReadLine().Split(" ");
                uint D = Convert.ToUInt32(rozdelene[0]);
                uint S = Convert.ToUInt32(rozdelene[1]);
                uint N = Convert.ToUInt32(rozdelene[2]);

                cas = S;

                for(int i = 0; i < N; i++)
                {
                    rozdelene = sr.ReadLine().Split(" ");
                    oteviraci = Convert.ToUInt32(rozdelene[0]);
                    zaviraci = Convert.ToUInt32(rozdelene[1]);
                    if (cas >= oteviraci && cas <= zaviraci)
                    {
                        cas = cas + 10;
                        polivky += 1;
                    }
                    cas += D;

                }

                Console.WriteLine(polivky);
                using (StreamWriter vystup = new StreamWriter("C:/Users/Michal/Documents/ksp/ksp_z_34_2_1_polivka/vystup.txt"))
                {
                    vystup.WriteLine(Convert.ToString(polivky));
                    vystup.Flush();
                }
            }

        }
    }
}
