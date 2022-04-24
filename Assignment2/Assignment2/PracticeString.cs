using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class PracticeString
    {
        // Q1
        public static void ConvertStringI()
        {
            Console.WriteLine("Enter your input string: ");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            for (int i = 0, j = input.Length - 1; i < j; i++, j--)
            {
                Swap(charArray, i, j);
            }
            Console.WriteLine($"The reversed string : \n{new string(charArray)}");
        }

        public static void ConvertStringII()
        {
            Console.WriteLine("Enter your input string: ");
            string input = Console.ReadLine();
            Console.WriteLine($"The reversed string :");
 
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }

        private static void Swap(char[] arr, int i, int j)
        {
            char ch = arr[i];
            arr[i] = arr[j];
            arr[j] = ch;
        }

        // Q2
        public static void ReverseWords()
        {
            Console.WriteLine("Enter the sentence: ");
            string sentence = Console.ReadLine();
            if (sentence == null)
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            HashSet<char> separators = new HashSet<char>() { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
            List<string> words = new List<string>();
            List<string> punctuations = new List<string>();
            int i = 0;
            int j = 0;
            while (j < sentence.Length)
            {
                while (j < sentence.Length && !separators.Contains(sentence[j]))
                {
                    j++;
                }
                words.Add(sentence.Substring(i, j - i));
                i = j;
                while (j < sentence.Length && separators.Contains(sentence[j]))
                {
                    j++;
                }
                punctuations.Add(sentence.Substring(i, j - i));
                i = j;
            }
            StringBuilder res = new StringBuilder();
            for (int k = 0; k < words.Count; k++)
            {
                res.Append(words[words.Count - k - 1]);
                res.Append(punctuations[k]);
            }
            Console.WriteLine(res.ToString());

        }

        // Q3
        public static void ExtractPalindrome()
        {
            Console.WriteLine("Enter the sentence: ");
            string sentence = Console.ReadLine();
            if (sentence == null)
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            List<string> res = new List<string>();
            HashSet<char> separators = new HashSet<char>() { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
            int i = 0;
            int j = 0;
            while (i < sentence.Length)
            {
                while (j < sentence.Length && !separators.Contains(sentence[j]))
                {
                    j++;
                }
                if (IsPalindrom(sentence, i, j - 1))
                {
                    res.Add(sentence.Substring(i, j - i));
                }
                j++;
                i = j;
            }
            res.Sort();
            Console.WriteLine("Palindroms are shown below :");
            foreach(string word in res)
            {
                Console.Write(word);
                Console.Write(",");
            }

        }

        private static bool IsPalindrom(string s, int i, int j)
        {   if (j < i)
            {
                return false;
            }
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }


        // Q4
        public static void ParseURL()
        {
            Console.WriteLine("Enter the URL: ");
            string url = Console.ReadLine();
            if (url == null)
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            string[] parts = url.Split('/', ':');
            if (parts.Length == 1)
            {
                Console.WriteLine("[protocol] = ....");
                Console.WriteLine($"[server] = {parts[0]}");
                Console.WriteLine("[resource] = ....");
            }
            else if (parts.Length == 2)
            {
                Console.WriteLine("[protocol] = ....");
                Console.WriteLine($"[server] = {parts[0]}");
                Console.WriteLine($"[resource] = {parts[1]}");
            }
            else if (parts.Length == 5)
            {
                Console.WriteLine($"[protocol] = {parts[0]}");
                Console.WriteLine($"[server] = {parts[3]}");
                Console.WriteLine($"[resource] = {parts[4]}");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

    }
}
