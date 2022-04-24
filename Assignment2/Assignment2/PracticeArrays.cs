using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    // Q1
    public static class PracticeArrays
    {
        public static void CopyArray(string[] original)
        {
            string[] copied = new string[original.Length];
            Console.WriteLine("O for original array, C for copied array");
            for (int i = 0; i < original.Length; i++)
            {
                copied[i] = original[i];
                Console.WriteLine($"O : {original[i]}, C : {copied[i]} ");
            }

        }

        //Q2
        public static void ShoppingList()
        {   List<string> shoppingList = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)): ");
                string command = Console.ReadLine();
                if (command == null || command.Length < 2)
                {
                    Console.WriteLine("Invalid command");
                    continue;
                }
                if (command[0] == '+' && command[1] == ' ')
                {
                    shoppingList.Add(command.Substring(2));
                    Console.WriteLine("Item added successfully");
                } else if (command[0] == '-' && command[1] == ' ')
                {
                    if (shoppingList.Remove(command.Substring(2)))
                    {
                        Console.WriteLine("Item deleted successfully");
                    }
                    else
                    {
                        Console.WriteLine("Deletion failed");
                        continue;
                    }       
                } else if (command[0] == '-' && command[1] == '-')
                {
                    shoppingList.Clear();
                    Console.WriteLine("Shopping list has been cleared");
                }
                else
                {
                    Console.WriteLine("Invalid command");
                }

                // show current shopping list
                Console.WriteLine("Your current shopping list : ");
                foreach (string s in shoppingList)
                {
                    Console.Write(s);
                    Console.Write(' ');
                }
                Console.WriteLine();

                // finish or continue
                Console.WriteLine("Press 0 to exit");
                Console.WriteLine("Press any other number to continue");
                int next = int.Parse(Console.ReadLine());
                if (next == 0)
                {
                    break;
                }
            }

            // display the final shopping list
            Console.WriteLine("Below is your final shooping list:");
            foreach (string s in shoppingList)
            {
                Console.Write(s);
                Console.Write(' ');
            }
            Console.WriteLine();
        }

        //Q3
        public static int[] FindPrimeInRange(int startNum, int endNum)
        {
            List<int> resList = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    resList.Add(i);
                }
            }
            return resList.ToArray();
        }

        private static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //Q4
        public static int[] RotateArraySum(int[] array, int times)
        {   
            int n = array.Length;
            int[] sum = new int[n];
           
             for (int i = 0; i < n; i++)
            {
                for (int k = 1; k <= times; k++)
                {
                    int index = i - k;
                    while (index < 0)
                    {
                        index += n;
                    }
                    sum[i] += array[index];
                }
            }
            return sum;
        }

        //Q5
        public static int[] LongestSequenceOfEqualElements(int[] input)
        {
            int maxCount = 1;
            int num = input[0];
            int i = 1;
            while (i < input.Length)
            {
                int count = 1;
                int cur = input[i - 1];
                while (input[i] == cur)
                {
                    count++;
                    i++;
                }
                if(count > maxCount)
                {
                    maxCount = count;
                    num = cur;
                }
                i++;
            }
            int[] res = new int[maxCount];
            for (int j = 0; j < maxCount; j++)
            {
                res[j] = num;
            }
            return res;

        }

        // Q6(Q7)

        public static void MostFrequentNum(int[] input)
        {
            Dictionary<int, int> numCountPair = new Dictionary<int, int>();
            int maxCount = 1;
            int numWithMaxCount = input[0];
            foreach (int i in input)
            {
                if (!numCountPair.ContainsKey(i))
                {
                    numCountPair.Add(i, 0);
                }
                numCountPair[i]++;
                if (numCountPair[i] > maxCount)
                {
                    maxCount = numCountPair[i];
                    numWithMaxCount = i;
                }
            }

            Console.WriteLine($"The number {numWithMaxCount} is the most frequent (occurs {maxCount} times)");
        }

    }

    
}
