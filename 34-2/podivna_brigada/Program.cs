using System;
using System.IO;

namespace ksp_z_34_2_1_polivka
{

    class Program
    {
        static void Main(string[] args)
        {
            


            using (StreamReader sr = new StreamReader("C:/Users/Michal/Documents/ksp/ksp_z_34_2_2_podivna_brigada/05.in"))
            {
                string[] rozdelene;
                //rozdelene = sr.ReadLine().Split(" ");

                uint N = Convert.ToUInt32(sr.ReadLine());
                uint kevin = 0;
                uint sara = 0;

                for (int i = 0; i < N; i++)
                {

                    if (kevin <= sara)
                    {
                        kevin += Convert.ToUInt32(sr.ReadLine());
                    }
                    else
                    {
                        sara += Convert.ToUInt32(sr.ReadLine());
                    }
                }

                Console.WriteLine(Math.Max(kevin, sara));
                //for ()
                //{
                //    rozdelene = sr.ReadLine().Split(" ");
                //}


                using (StreamWriter vystup = new StreamWriter("C:/Users/Michal/Documents/ksp/ksp_z_34_2_2_podivna_brigada/vystup.txt"))
                {
                    vystup.WriteLine(Math.Max(kevin, sara));
                    vystup.Flush();
                }


            }

           
        }
    }
}
