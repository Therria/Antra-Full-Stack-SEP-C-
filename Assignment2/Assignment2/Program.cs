/*
 Test yout knowlegde

* Q1
If a string is going to remain constant throughout the program then use String since it is immutable,
If a string need to be changed while using than use StingBuilder since it is mutable

* Q2
Array types are reference types derived from the abstract base type Array

* Q3
using Array.Sort() method

* Q4
using Array.Length propertity

* Q5
No. If you want to store multiple data types, use ArrayList

* Q6
             System.Array.CopyTo()                      vs            System.Array.Clone()
1)                 deep copy                                             shallow copy
2) copies the elements of one array to another array         creates a copy of an array as an object
3)        requires a destination array                               not requires destination array

 */

using Assignment2;

// Practice Array
// Q1

string[] array1 = new string[] { "Apple", "Banana", "Orange", "Strawberry", "Watermelon", "Lemon", "Cherry", "Mango", "Grapes", "Kiwifruit" };
PracticeArrays.CopyArray(array1);

Console.WriteLine("----------------------------------------------------------------------------");

// Q2
//PracticeArrays.ShoppingList();

Console.WriteLine("----------------------------------------------------------------------------");
//Q3
Console.WriteLine("Enter your finding range:");
Console.WriteLine("Start number : ");
int startNum = int.Parse(Console.ReadLine());
Console.WriteLine("End number : ");
int endNum = int.Parse(Console.ReadLine());
int[] listOfPrimeNum = PracticeArrays.FindPrimeInRange(startNum, endNum);
foreach (int i in listOfPrimeNum)
{
    Console.Write(i);
    Console.Write(' ');
}
Console.WriteLine();

Console.WriteLine("----------------------------------------------------------------------------");

//Q4
// input array 
List<int> list4 = new List<int>();
Console.WriteLine("Input elements in the array (Press # to finish typing) :");
int input4Index = 0;
while (true)
{
    Console.Write("index - {0} : ", input4Index);
    string input4 = Console.ReadLine();
    if (input4 == null || input4.Length == 0)
    {
        Console.WriteLine("Invalid input");
        continue;
    }
    if (input4[0] == '#')
    {
        break;
    }
    else
    {
        list4.Add(int.Parse(input4));
        input4Index++;
    }
}
// input times
Console.Write("Enter the rotation times :");
int rotateTimes = int.Parse(Console.ReadLine());
int[] sum = PracticeArrays.RotateArraySum(list4.ToArray(), rotateTimes);
// display result
Console.WriteLine("The sum array is shown below :");
foreach (int i in sum)
{
    Console.Write(i);
    Console.Write(' ');
}
Console.WriteLine();

Console.WriteLine("----------------------------------------------------------------------------");

//Q5
// input array
List<int> list5 = new List<int>();
Console.WriteLine("Input elements in the array (Press # to finish typing) :");
int input5Index = 0;
while (true)
{
    Console.Write("index - {0} : ", input5Index);
    string input5 = Console.ReadLine();
    if (input5 == null || input5.Length == 0)
    {
        Console.WriteLine("Invalid input");
        continue;
    }
    if (input5[0] == '#')
    {
        break;
    }
    else
    {
        list5.Add(int.Parse(input5));
        input5Index++;
    }
}
int[] longest = PracticeArrays.LongestSequenceOfEqualElements(list5.ToArray());
// display result
Console.WriteLine("The result array is shown below :");
foreach (int i in longest)
{
    Console.Write(i);
    Console.Write(' ');
}
Console.WriteLine();

Console.WriteLine("----------------------------------------------------------------------------");

//Q6 (Q7)
// input array
List<int> list6 = new List<int>();
Console.WriteLine("Input elements in the array (Press # to finish typing) :");
int input6Index = 0;
while (true)
{
    Console.Write("index - {0} : ", input6Index);
    string input6 = Console.ReadLine();
    if (input6 == null || input6.Length == 0)
    {
        Console.WriteLine("Invalid input");
        continue;
    }
    if (input6[0] == '#')
    {
        break;
    }
    else
    {
        list6.Add(int.Parse(input6));
        input6Index++;
    }
}
PracticeArrays.MostFrequentNum(list6.ToArray());

Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine("----------------------------------------------------------------------------");

// Practice String
// Q1
// using method I
Console.WriteLine("Using method I : Convert the string to char array, reverse it, then convert it to string again");
PracticeString.ConvertStringI();
// using method II
Console.WriteLine("Using method II : Print the letters of the string in back direction (from the last to the first) in a for-loop");
PracticeString.ConvertStringII();

Console.WriteLine("----------------------------------------------------------------------------");

// Q2
PracticeString.ReverseWords();

Console.WriteLine("----------------------------------------------------------------------------");

// Q3
// PracticeString.ExtractPalindrome();

Console.WriteLine("----------------------------------------------------------------------------");

// Q4
PracticeString.ParseURL();
