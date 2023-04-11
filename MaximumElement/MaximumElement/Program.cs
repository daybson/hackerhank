namespace MaximumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de queries: ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> ops = new List<string>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite a query: ");
                string opsItem = Console.ReadLine();
                ops.Add(opsItem);
            }

            List<int> res = Result.getMax(ops);

            Console.WriteLine(String.Join("\n", res));
        }
    }


    class Result
    {

        /*
         * Complete the 'getMax' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts STRING_ARRAY operations as parameter.
         */

        public static List<int> getMax(List<string> operations)
        {
            Stack<int> stack = new Stack<int>();
            int max = -1;
            var resp3 = new List<int>();

            for (int i = 0; i < operations.Count; i++)
            {
                switch (operations[i][0])
                {
                    case '1':
                        int element = int.Parse(operations[i].Split(' ').Last());
                        stack.Push(element);

                        if (element > max)
                            max = element;

                        break;
                    case '2':
                        var top = stack.First();
                        stack.Pop();

                        if (top == max)
                        {
                            if (stack.Count > 0)
                                max = stack.Max();
                            else
                                max = -1;
                        }

                        break;
                    case '3':
                        resp3.Add(max);
                        Console.WriteLine(max);
                        break;

                }
            }

            return resp3;
            /**
             * 
            Stack<int> stack = new Stack<int>();
            Stack<int> stackMax = new Stack<int>();
        
            var resp3 = new List<int>();

            for (int i = 0; i < operations.Count; i++)
            {
                switch (operations[i][0])
                {
                    case '1':
                        int element = int.Parse(operations[i].Split(' ').Last());
                        stack.Push(element);
                        
                        if (stackMax.Count == 0)
                        {
                            stackMax.Push(element);
                            continue;
                        }
                            
                        if (element > stackMax.First())
                            stackMax.Push(element);
                        else
                            stackMax.Push(stackMax.First());

                        break;
                    case '2':                        
                        stack.Pop();
                        stackMax.Pop();
                        break;
                    case '3':
                        resp3.Add(stackMax.First());
                        Console.WriteLine(stackMax.First());
                        break;
                }
            }

            return resp3;
             * */
        }

    }

}