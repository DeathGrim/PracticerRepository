using System;

namespace GetResult
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input: ");
                string input = Console.ReadLine();
                string ouput = GetResults(input);
                Console.WriteLine("Output: " + ouput );
              
            }
        }
        
        
        static string CountRepeatSymbols(string str)
        {
            string seached = "";
            string witholdSymbols = str;
            string newString;
            int count;
            char currentSearch;

            while (true)
            {

                count = 0;
                newString = "";
                currentSearch = witholdSymbols[0];
                foreach (char c in witholdSymbols)
                {
                    if (c == currentSearch)
                    {
                        count++;
                    }
                    else
                    {
                        newString += c;
                    }
                }
                if (count >= 1)
                {
                    seached += currentSearch + " - " + count + ", ";
                }
                witholdSymbols = newString;
                if (newString == "")
                {
                    return seached;
                }
            }
        }
        static string Substringfind(string result)
        {
            string Symbols = "aeiouy";
            for (int i = 0; i < result.Length; i++)
            {
                if (Symbols.IndexOf(result[i]) != -1)
                {
                    for (int j = result.Length - 1; j >= i; j--)
                    {
                        if (Symbols.IndexOf(result[j]) != -1)
                        {
                            return result.Substring(i, j - i + 1);
                        }

                    }
                }
            }
            return "";
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
                return "Wrong Symbols: " + notCorrect;
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
                result = resultsFirst + resultSecond;

            }
            else
            {
                char[] resultElse = input.ToCharArray();
                Array.Reverse(resultElse);
                string reversed = new string(resultElse);
                result = reversed + input;

            }
            string doubleSymbols = CountRepeatSymbols(result);
            string substr = Substringfind(result);
            if (doubleSymbols != "")
            {
                Console.WriteLine("Count symbols " + doubleSymbols);
            }
            Console.WriteLine("Substring: " + substr);
            return result;
        }
    }
}
