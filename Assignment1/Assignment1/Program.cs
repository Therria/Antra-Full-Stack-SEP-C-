using System.Text;
using Assignment1;


// Part I : Understanding Dta Types

/*
Test your Knowledge

* Q1
A person’s telephone number : string
A person’s height : ushort
A person’s age : ushort
A person’s gender (Male, Female, Prefer Not To Answer) : string
A person’s salary : ufloat
A book’s ISBN : ulong
A book’s price : ufloat
A book’s shipping weight : ufloat
A country’s population : ulong
The number of stars in the universe : ulong
The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business) : uint

* Q2
value type vs. reference type
1) value type holds the value                  while reference type hold the memory address or reference for the value
2) value type is stored in stack memory        while reference type is stored in heap memory
3) value type will not be collected by GC      while reference type will be collected by GC
4) value type can be created by Struct, Enum   while reference type can be created by Class, Interface, Delegate, Array
5) value type can not have Null value          while reference type can have Null value

boxing : convert value type to reference type
unboxing : convert reference type to value type

* Q3
Managed resources are managed by the CLR in .NET while unmanaged resources are directly excuted by operating system, like files, streams, database connections.
Managed resources provide runtime services like GC, Exception handling, etc. while unmanaged resources do not.

* Q4
GC is to manage the allocation and release of memory for an application
*/



// Practices
// practice 1
UnderstandingTypes.TypeRangeAndExtremum();

Console.WriteLine("-----------------------------------------------------------------------------");
// practice 2
UnderstandingTypes.TimeCovertion();

Console.WriteLine("-----------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------------------------------------------------");


// Part II : Controlling Flow and Converting Types

/* 
Test your Knowledge

* Q1
It throw an error that Exception Unhandled, the Exception is System.DivideByZeroException : 'Attempted to divide by zero'

* Q2
Excuted successfully and the answer is infinity OO

* Q3
It throws an error, it says "Cannot implicity convert type 'uint' to 'int'"

* Q4
x = y++ will assign the value of y to x first then do y = y + 1
x = ++y will do y = y + 1 first then assign the new value of y to x

Eg: y = 1
if x = y++, then x = 1, y = 2
if x = ++y, then x = 2, y = 2

* Q5
break will terminates the innermost loop that contains it
continue will terminate current iteration and start a new iteration of the closest loop that congtains it
return will terminates execution out of the function 

* Q6
for (initializor ; condition ; iterator)
condition section is required

* Q7
x = y is to assign the value of y to x
x == y is to judge whether x equal to y or not.

* Q8
Yes, it will compile but will go into a dead loop.

* Q9
underscore _ represents 'default' in switch statemnt

* Q10
IEnumerable interface

*/

// Practices
Console.WriteLine("-----------------------------------------------------------------------------");
// practice 1
FizzBuzz.CountToOnrHundred();

/*int max = 500;
for (byte i = 0; i < max; i++)
{
    Console.WriteLine(i);
}*/

// The code above will print 0 to 255 again and again, step into a dead loop
// since the maximum value of the byte type is 255 which is always samller than 500, making the condition section always true.

// add code: if (i == sizeof(byte)) break;

Console.WriteLine("-----------------------------------------------------------------------------");
// practice 2
Pyramid.printPyramid(5);

Console.WriteLine("-----------------------------------------------------------------------------");
// practice 3
GuessRandomNum.Guess();

Console.WriteLine("-----------------------------------------------------------------------------");
// prectice 4
Birthday.CalculateAge(new DateTime(1996,12,3,15,0,0));

Console.WriteLine("-----------------------------------------------------------------------------");
// practice 5
Greeting.GreetingWords(DateTime.Now);

Console.WriteLine("-----------------------------------------------------------------------------");
// practice 6
CountTo24.Count();
Console.WriteLine("-----------------------------------------------------------------------------");
