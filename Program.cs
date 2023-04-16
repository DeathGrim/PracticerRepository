using System;

namespace GetResult
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ввод: ");
                string input = Console.ReadLine();
                string ouput = GetResults(input);
                Console.WriteLine("Вывод: " + ouput);

            }
        }
        static string GetResults(string input)
        {
            string result;
            string correct = "abcdefghijklmnopqrstuvwxyz";
            string notCorrect = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (correct.IndexOf(input[i]) == -1)
                {
                    notCorrect += input[i];

                }

            }
            if (notCorrect.Length > 0)
            {
                return "Не верные символы: " + notCorrect;
            }
            if (input.Length % 2 == 0)
            {
                int half = input.Length / 2;
                string first = input.Substring(0, half);
                string second = input.Substring(half);
                char[] resultsFirstMeating = first.ToCharArray();
                Array.Reverse(resultsFirstMeating);
                string resultsFirst = new string(resultsFirstMeating);
                char[] resultsSecond = second.ToCharArray();
                Array.Reverse(resultsSecond);
                string resultSecond = new string(resultsSecond);
                string getresult = resultsFirst + resultSecond;
                return getresult;
            }
            else
            {
                char[] resultElse = input.ToCharArray();
                Array.Reverse(resultElse);
                string reversed = new string(resultElse);
                string resultReverse = reversed + input;
                return resultReverse;
            }
        }
    }
}
