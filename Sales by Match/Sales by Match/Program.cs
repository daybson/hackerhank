using System.Linq;

namespace Sales_by_Match
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de elementos: ");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("Elementos separados por espaço: ");
            var arrayStr = Console.ReadLine().Split(" ");

            var array = new int[arrayStr.Length];
            for (int i = 0; i < arrayStr.Length; i++)
            {
                array[i] = int.Parse(arrayStr[i]);
            }

            int result = Result.sockMerchant(n, array.ToList());
            Console.WriteLine("Total de pares na sequência: " + result);
        }
    }

    class Result
    {

        /*
         * Complete the 'sockMerchant' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER_ARRAY ar
         */

        public static int sockMerchant(int n, List<int> ar)
        {
            int result = 0;
            ar.GroupBy(a => a).ToList().ForEach(e => result += e.Count() / 2);

            // var group = ar.GroupBy(a => a);
            // foreach (var item in group)
            // {
            //     result += item.Count() / 2;
            // }

            return result;
        }

    }

}