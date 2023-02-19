namespace ЛР_7_lvl2_6
{
    class Sportsmen
    {
        public string surname;
        public int res1, res2;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sportsmen[] sp = new Sportsmen[5];
            for (int i = 0; i < sp.Length; i++) sp[i] = new Sportsmen();
            string[] s = new string[] { "Filin", "Platov", "Sergeev", "Shastun", "Ivanov" };
            int[] sumr = new int[5];
            string eq = "=";
            Random rnd = new Random();
            Console.WriteLine("SURNAME |RESULT");
            for (int i = 0; i < sp.Length; i++)
            {
                sp[i].surname = s[i];
                sp[i].res1 = rnd.Next(5, 26);
                sp[i].res2 = rnd.Next(5, 26);
                Console.WriteLine($"{sp[i].surname}\t|{sp[i].res1 + sp[i].res2}");
            }
            for (int i = 0; i <= 14; i++) Console.Write(eq);
            Console.WriteLine();
            for (int i = 0; i < sp.Length; i++)
            {
                int amax = sp[i].res1 + sp[i].res2;
                int imax = i;
                for (int j = i + 1; j < sp.Length; j++)
                {
                    if (sp[j].res1 + sp[j].res2 > amax)
                    {
                        amax = sp[j].res1 + sp[j].res2;
                        imax = j;
                    }
                }
                Sportsmen temp;
                temp = sp[i];
                sp[i] = sp[imax];
                sp[imax] = temp;
                Console.WriteLine($"{sp[i].surname}\t|{sp[i].res1 + sp[i].res2}");

            }

        }
    }
}