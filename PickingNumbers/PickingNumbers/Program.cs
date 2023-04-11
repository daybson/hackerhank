namespace PickingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of the array: ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Space - separated integers: ");
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = Result.pickingNumbers(a);

            Console.WriteLine(result);
        }
    }


    class Result
    {

        /*
         * Complete the 'pickingNumbers' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         * 
         * 1 1 2 2 4 4 5 5 5
         * [1, 1, 2, 2, 4, 4, 5, 5, 5]
         *  0  0  2  2
         */

        public static int pickingNumbers(List<int> a)
        {
            int[] frequency = new int[101];
            int result = -1;

            for (int i = 0; i < a.Count; i++)
            {
                int index = a.IndexOf(i);
                frequency[index]++;
            }

            for (int i = 1; i <= 100; i++)
                result = Math.Max(result, frequency[i] + frequency[i - 1]);

            return result;
            /*
            int firstElement = a[0];
            int indexFirstElement = 0;
            int indexSecondElement = 0;
            int maxSize = 0;

            for (int i = 0; i < a.Count; i++)
            {
                //if (first - a[i] == 0)
                //    indexFirstElement = i;

                if (Math.Abs(firstElement - a[i]) == 1)
                    indexSecondElement = i;

                else if (Math.Abs(firstElement - a[i]) > 1)
                {
                    firstElement = a[i];
                    indexFirstElement = i;
                }

                if (indexSecondElement - indexFirstElement > maxSize)
                    maxSize = indexSecondElement - indexFirstElement;
            }

            return maxSize + 1;
            */
        }

    }
}