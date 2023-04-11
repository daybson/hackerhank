namespace CountingValleys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de steps: ");
            var n = long.Parse(Console.ReadLine());

            Console.WriteLine("Passos: ");
            var s = Console.ReadLine();

            var result = Result.countingValleys(n, s);

            Console.WriteLine("Quantidade de vales: " + result);
        }
    }

    class Result
    {
        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */

        public static int countingValleys(long steps, string path)
        {
            var count = 0;
            int vale = 0;
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i].Equals('U'))
                {
                    count++;
                    if (count == 0)
                        vale++;
                }
                else
                {
                    count--;
                }
            }

            return vale;
        }

    }
}