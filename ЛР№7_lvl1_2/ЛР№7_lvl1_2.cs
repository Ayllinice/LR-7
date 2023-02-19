﻿using System.ComponentModel.DataAnnotations;

namespace ЛР_7_lvl1_2
{
    class Sportsmen
    {
        public string surname; public int group;
        public string tsurn, norm; public int res;
    }
    internal class Program
    {
        static void Main(string[] args)
        {   
            Sportsmen[] sp = new Sportsmen[4];
            for (int i = 0; i < sp.Length; i++) sp[i] = new Sportsmen();
            string[] s = new string[] { "Ivanov", "Petrov", "Sidorov", "Filin" };
            string[] ts = new string[] { "Korpatova", "Smetuhova", "Bogdanova", "Platova" };
            int norm = 60;
            int k = 0;
            string con, eq = "=";
            Random rand = new Random();
            Random rnd = new Random();
            Console.WriteLine("SURNAME |RESULT |TEACH'S NAME\t|TEAM");
            for (int i = 0; i < sp.Length; i++)
            {
                sp[i].surname = s[i];
                sp[i].tsurn = ts[i];
                sp[i].res = rnd.Next(40,80);
                sp[i].group = rand.Next(1, 3);
                Console.WriteLine($"{sp[i].surname}\t|{sp[i].res}\t|{sp[i].tsurn}\t|{sp[i].group} ");
            }
            for (int i = 0; i <= 50; i++) Console.Write(eq);
            Console.WriteLine();
            for (int i = 0; i < sp.Length; i++)
            {
                int amax = sp[i].res;
                int imax = i;
                for (int j = i+1; j < sp.Length; j++)
                {
                    if (sp[j].res < amax)
                    {
                        amax = sp[j].res;
                        imax = j;
                    }
                }
                Sportsmen temp;
                temp = sp[imax];
                sp[imax] = sp[i];
                sp[i] = temp;
            }
            for (int i = 0; i < sp.Length; i++)
            {
                if (sp[i].res < norm)
                {
                    con = "passed";
                    k += 1;
                }
                else con = "not pass";
                Console.WriteLine($"{sp[i].surname}\t|{sp[i].res}\t|{sp[i].tsurn}\t|{sp[i].group}\t|norm: {con}");
            }
            Console.WriteLine($"Summary of participants that passed the standart: = {k}");
        }
    }
}
