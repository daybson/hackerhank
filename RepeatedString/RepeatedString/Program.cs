namespace RepeatedString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String de repetição: ");
            var s = Console.ReadLine();

            Console.WriteLine("Quantidade de caracteres: ");
            var n = long.Parse(Console.ReadLine());

            var result = Result.repeatedString(s, n);

            Console.WriteLine("Quantidade de 'A's: " + result);
        }
    }


    class Result
    {

        /*
         * Complete the 'repeatedString' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. LONG_INTEGER n
         */

        public static long repeatedString(string s, long n)
        {
            var clonestr = string.Empty;
            int cloneIndex = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    if (i % s.Length == 0)
            //        cloneIndex = 0;

            //    clonestr += s[cloneIndex++];
            //}

            var fullRepeatitions = n / s.Length;

            var aOccurrencesInOneString = s.Count(a => a.Equals('a'));

            var repetitionIntegerPart = fullRepeatitions * aOccurrencesInOneString;


            var tailString = s.Substring(0, ((int)n - (int)(fullRepeatitions * s.Length)));


            for (int i = 0; i < tailString.Length; i++)
            {

                clonestr += s[i];
            }

            return repetitionIntegerPart + clonestr.Count(a => a.Equals('a'));
        }

    }
}