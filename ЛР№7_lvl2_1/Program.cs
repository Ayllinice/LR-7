namespace ЛР_7_lvl2_7
{
    class Sportsmen
    {
        public string surname;
        public double point;
        public void res(int n, out double points)
        {
            Random rnd = new Random();
            double r = 0;
            points = 0;
            for (int i = 0; i < n; i++)
            {
                r = rnd.Next(0, 3) * 0.5;
                points += r;
            }
        }
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
            double[] p = new double[5];
            Console.WriteLine("SURNAME |RESULT");
            for (int i = 0; i < sp.Length; i++)
            {
                sp[i].surname = s[i];
                sp[i].res(5,out p[i]);
                sp[i].point = p[i];
                Console.WriteLine($"{sp[i].surname}\t|{sp[i].point}");
            }
            for (int i = 0; i <= 14; i++) Console.Write(eq);
            Console.WriteLine();
            for (int i = 0; i < sp.Length; i++)
            {
                double amax = sp[i].point;
                int imax = i;
                for (int j = i + 1; j < sp.Length; j++)
                {
                    if (sp[j].point > amax)
                    {
                        amax = sp[j].point;
                        imax = j;
                    }
                }
                Sportsmen temp;
                temp = sp[i];
                sp[i] = sp[imax];
                sp[imax] = temp;
                Console.WriteLine($"{sp[i].surname}\t|{sp[i].point}");

            }

        }
    }
}