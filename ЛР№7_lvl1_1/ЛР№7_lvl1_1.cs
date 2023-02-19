namespace ЛР_7_lvl1_1
{
    class Sportsmen
    {
        public string surname;
        public int res1;
        public int res2;
    }
    class Sporteam: Sportsmen
    {
        public int team;
    }
    internal class Program
    {
        static void Main()
        {
            Sporteam[] sp = new Sporteam[4];
            for (int i = 0; i < 4; i++) sp[i] = new Sporteam();
            string[] s = new string[] { "Ivanov", "Petrov", "Sidorov", "Filin" };
            int[] r1 = new int[] { 29, 18, 33, 60 };
            int[] r2 = new int[] { 30, 31, 45, 19 };
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                sp[i].surname = s[i];
                sp[i].res1 = r1[i];
                sp[i].res2 = r2[i];
                sp[i].team = rand.Next(1,3);
                Console.WriteLine($"surn={sp[i].surname} r1={sp[i].res1} r2={sp[i].res2} team={sp[i].team} ");
            }
            for (int i = 0; i < sp.Length; i++)
            {
                int amax = sp[i].res1 + sp[i].res2;
                int imax = i;
                for (int j = i + 1; j < sp.Length; j++)
                {
                    if ((sp[j].res1 + sp[j].res2) > amax)
                    {
                        amax = sp[j].res1 + sp[j].res2;
                        imax = j;
                    }
                }
                Sporteam temp;
                temp = sp[imax];
                sp[imax] = sp[i];
                sp[i] = temp;
            }
            Console.WriteLine();
            for (int i = 0; i < sp.Length; i++)
            {
                Console.WriteLine($"place: {i+1}, Surn={sp[i].surname}, result= {(sp[i].res1 + sp[i].res2)}, team = {sp[i].team}");
            }
        }
    }
}