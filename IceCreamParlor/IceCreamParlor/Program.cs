namespace IceCreamParlor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantidade de idas a sorveteria: ");
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                Console.WriteLine("Dinheiro gasto: ");
                int m = Convert.ToInt32(Console.ReadLine().Trim());

                Console.WriteLine("Quantidade de sabores: ");
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                Console.WriteLine("Preço dos sabores [array]: ");
                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                List<int> result = Result.icecreamParlor(m, arr);

                Console.WriteLine(String.Join(" ", result));
            }
        }
    }


    class Result
    {

        /*
         * Complete the 'icecreamParlor' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER m
         *  2. INTEGER_ARRAY arr
         */

        public static List<int> icecreamParlor(int m, List<int> arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Count; i++)
            {
                var s2 = m - arr[i];

                if (!map.Keys.Contains(s2))
                {
                    map.Add(arr[i], i);
                }
                else
                {
                    return new List<int>()
                    {
                        map[s2] + 1,
                        i + 1
                    };
                }
            }

            return new List<int>() { -1, -1 };
        }

    }
}