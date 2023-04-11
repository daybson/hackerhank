namespace jumpingOnClouds
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sequencia de nuvens: ");
            List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

            int result = Result.jumpingOnClouds(c);

            Console.WriteLine("Total de saltos: " + result);
        }
    }


    class Result
    {
        /*
         * Complete the 'jumpingOnClouds' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY c as parameter.
         */

        public static int jumpingOnClouds(List<int> c)
        {  
            int currJumps = 0; 

            for (int i = 0; i < c.Count-1;  )
            {
                if (i < c.Count - 2 && c[i + 2] == 0)
                {
                    currJumps++;
                    i += 2;
                }
                //else if (i < c.Count - 2 && c[i + 2] == 1)
                //{
                //    currJumps += 1;
                //    i += 1;
                //}
                else
                {
                    currJumps += 1;
                     i += 1;
                }
            }

            return currJumps;
        }

    }
}