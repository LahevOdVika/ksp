using System;
using System.IO;
using System.Collections.Generic;
namespace _34_Z3
{
   class Program
   {
       
        static void Main(string[] args)
        {
            
            using (StreamReader sr = new StreamReader("C:/Users/Michal/OneDrive/Dokumenty/ksp/ksp_z_34_3_1/34-Z3/05.in"))
            {
                Dictionary<string, string> morzeovka = new Dictionary<string, string>();
                uint N = Convert.ToUInt32(sr.ReadLine());
                                
                    
                morzeovka.Add("A", ".-");
                morzeovka.Add("B", "-...");
                morzeovka.Add("C", "-.-.");
                morzeovka.Add("D", "-..");
                morzeovka.Add("E", ".");
                morzeovka.Add("F", "..-.");
                morzeovka.Add("G", "--.");
                morzeovka.Add("H", "....");
                morzeovka.Add("I", "..");
                morzeovka.Add("J", ".---");
                morzeovka.Add("K", "-.-");
                morzeovka.Add("L", ".-..");
                morzeovka.Add("M", "--");
                morzeovka.Add("N", "-.");
                morzeovka.Add("O", "---");
                morzeovka.Add("P", ".--.");
                morzeovka.Add("Q", "--.-");
                morzeovka.Add("R", ".-.");
                morzeovka.Add("S", "...");
                morzeovka.Add("T", "-");
                morzeovka.Add("U", "..-");
                morzeovka.Add("V", "...-");
                morzeovka.Add("W", ".--");
                morzeovka.Add("X", "-..-");
                morzeovka.Add("Y", "-.--");
                morzeovka.Add("Z", "--..");
                morzeovka.Add("1", ".----");
                morzeovka.Add("2", "..---");
                morzeovka.Add("3", "...--");
                morzeovka.Add("4", "....-");
                morzeovka.Add("5", ".....");
                morzeovka.Add("6", "-....");
                morzeovka.Add("7", "--...");
                morzeovka.Add("8", "---..");
                morzeovka.Add("9", "----.");
                morzeovka.Add("0", "-----");

                StreamWriter vystup = new StreamWriter("C:/Users/Michal/OneDrive/Dokumenty/ksp/ksp_z_34_3_1/34-Z3/vystup.txt");

                for (int i = 0; i < N; i++)
                {
                    string slovo = sr.ReadLine();
                    string doMorzeovky = "";
                    string v="ANO";
                    
                    for(int j = 0; j < slovo.Length; j++)
                    {
                        doMorzeovky += morzeovka.GetValueOrDefault(slovo[j].ToString());
                    }

                    int delkaM = doMorzeovky.Length;
                    for(int j = 0; j < delkaM / 2; j++)
                    {
                        if (doMorzeovky[j] == doMorzeovky[delkaM - j - 1])
                        {
                            
                            
                        }
                        else
                        {
                            v = "NE";
                            break;
                        }
                    }
                    vystup.WriteLine(v);
                }
                vystup.Flush();

            }
        }   
    }
}
