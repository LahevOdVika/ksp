using System;
using System.IO;

class ukol {
    static void Main(string[] args) {
        StreamReader sr = new StreamReader("C:/Users/Lahev/Documents/ksp/kevin_a_magnetky/kevin_a_magnetky/01.in");

        int N = Convert.ToInt32(sr.ReadLine());
        int pocet = 0;
        char pol = 'a';

        for (int i = 0; i < N; i++) {
            string magnet = sr.ReadLine();

            if (pocet == 0) {
                
                pol = magnet[1];
                pocet += 1;
            } else if (pol != magnet[0]) {
                pol = magnet[1];
                pocet += 1;
            }
        }
        Console.WriteLine(pocet);
    }
}