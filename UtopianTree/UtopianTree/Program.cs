namespace UtopianTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de testes:");
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                Console.WriteLine("Quantidade de ciclos:");
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int result = Result.utopianTree(n);

                Console.WriteLine(result);
            }
        }
    }



    class Result
    {

        /*
         * Complete the 'utopianTree' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER n as parameter.
         */

        public static int utopianTree(int n)
        {
            int height = 1;

            for (int i = 1; i <= n; i++)
            {
                if(i % 2 == 1)
                    height *= 2;
                else
                    height++;
            }

            return height;
        }

    }
}