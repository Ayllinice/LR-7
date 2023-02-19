using System.Diagnostics;
using System.Text;

namespace ЛР_7_lvl2_8
{
    class Sportsmen
    {
        public string surname;
        public int point;
        public void fine(out int min)
        {
            Random rand = new Random();
            int[] numbers = { 2, 5, 10 };
            min = numbers[rand.Next(numbers.Length)];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[] { "Ivanov","Smirnov","Kuznetsov","Popov","Sokolov","Lebedev","Kozlov","Novikov","Morozov","Petrov",
                "Volkov","Solovyov","Vasiliev","Zaitsev","Pavlov","Semyonov","Gusev","Vinogradov","Bogdanov",
                "Vorobyov","Fedorov","Makarov","Titov","Sidorov","Krylov","Yakovlev","Ryzhkov","Smirnova","Orlov","Dmitriev" };
            Sportsmen[] sp = new Sportsmen[30];
            for (int i = 0; i < sp.Length; i++) sp[i] = new Sportsmen();
            string eq = "=";
            Random rnd = new Random();
            int[] p = new int[30];
            int k = 0;
            Console.WriteLine("SURNAME \t\tRESULT");
            for (int i = 0; i <= 30; i++) Console.Write(eq);
            Console.WriteLine();
            for (int i = 0; i < sp.Length; i++)
            {
                sp[i].fine(out p[i]);
                sp[i].point = p[i];
                sp[i].surname = s[i];
                Console.WriteLine($"{sp[i].surname}, {sp[i].point}");
            }
            for (int i = 0; i <= 30; i++) Console.Write(eq);
            Console.WriteLine("\n");
            for (int i = 0; i < sp.Length; i++)
            {
                double amax = sp[i].point;
                int imax = i;
                for (int j = i + 1; j < sp.Length; j++)
                {
                    if (sp[j].point < amax)
                    {
                        amax = sp[j].point;
                        imax = j;
                    }
                }
                Sportsmen temp;
                temp = sp[i];
                sp[i] = sp[imax];
                sp[imax] = temp;
            }
            for (int i = 0; i < sp.Length; i++)
            {
                if (sp[i].point != 10)
                {
                    Console.WriteLine($"{sp[i].surname}, {sp[i].point}");
                }
            }
            
            
        }

    }
    //public static class TableParser
    //{
    //    public static string ToStringTable<T>(
    //      this IEnumerable<T> values,
    //      string[] columnHeaders,
    //      params Func<T, object>[] valueSelectors)
    //    {
    //        return ToStringTable(values.ToArray(), columnHeaders, valueSelectors);
    //    }

    //    public static string ToStringTable<T>(
    //      this T[] values,
    //      string[] columnHeaders,
    //      params Func<T, object>[] valueSelectors)
    //    {
    //        Debug.Assert(columnHeaders.Length == valueSelectors.Length);

    //        var arrValues = new string[values.Length + 1, valueSelectors.Length];

    //        // Fill headers
    //        for (int colIndex = 0; colIndex < arrValues.GetLength(1); colIndex++)
    //        {
    //            arrValues[0, colIndex] = columnHeaders[colIndex];
    //        }

    //        // Fill table rows
    //        for (int rowIndex = 1; rowIndex < arrValues.GetLength(0); rowIndex++)
    //        {
    //            for (int colIndex = 0; colIndex < arrValues.GetLength(1); colIndex++)
    //            {
    //                arrValues[rowIndex, colIndex] = valueSelectors[colIndex]
    //                  .Invoke(values[rowIndex - 1]).ToString();
    //            }
    //        }

    //        return ToStringTable(arrValues);
    //    }

    //    public static string ToStringTable(this string[,] arrValues)
    //    {
    //        int[] maxColumnsWidth = GetMaxColumnsWidth(arrValues);
    //        var headerSpliter = new string('-', maxColumnsWidth.Sum(i => i + 3) - 1);

    //        var sb = new StringBuilder();
    //        for (int rowIndex = 0; rowIndex < arrValues.GetLength(0); rowIndex++)
    //        {
    //            for (int colIndex = 0; colIndex < arrValues.GetLength(1); colIndex++)
    //            {
    //                // Print cell
    //                string cell = arrValues[rowIndex, colIndex];
    //                cell = cell.PadRight(maxColumnsWidth[colIndex]);
    //                sb.Append(" | ");
    //                sb.Append(cell);
    //            }

    //            // Print end of line
    //            sb.Append(" | ");
    //            sb.AppendLine();

    //            // Print splitter
    //            if (rowIndex == 0)
    //            {
    //                sb.AppendFormat(" |{0}| ", headerSpliter);
    //                sb.AppendLine();
    //            }
    //        }

    //        return sb.ToString();
    //    }

    //    private static int[] GetMaxColumnsWidth(string[,] arrValues)
    //    {
    //        var maxColumnsWidth = new int[arrValues.GetLength(1)];
    //        for (int colIndex = 0; colIndex < arrValues.GetLength(1); colIndex++)
    //        {
    //            for (int rowIndex = 0; rowIndex < arrValues.GetLength(0); rowIndex++)
    //            {
    //                int newLength = arrValues[rowIndex, colIndex].Length;
    //                int oldLength = maxColumnsWidth[colIndex];

    //                if (newLength > oldLength)
    //                {
    //                    maxColumnsWidth[colIndex] = newLength;
    //                }
    //            }
    //        }

    //        return maxColumnsWidth;
    //    }
    //}
}