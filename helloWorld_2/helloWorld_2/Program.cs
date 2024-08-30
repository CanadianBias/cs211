// Directives
using System; // includes system functions like read() and writeLine()

// Single line comment

/*
    Multi - line comment
*/

// namespace is a grouping of related code elements
// above directives reference existing namespaces
// below we are creating a new namespace and defining it's elements

namespace helloWorld_2
{
    internal class Program // within a namespace, we define classes which have properties and methods
    {
        static void Main(string[] args) // this is the main method of the class, the root of the program in this case
        {
            // Write "Hello" on the screen
            Console.WriteLine("Hello, World!");

            string strName = "Eli";
            int age = 21;
            Console.WriteLine("Hello, my name is " + strName + age);

            string phrase = "Some set of characters";
            char letter = 'a'; // single characters require single quotes
            int wholeNumber = 5;
            float fltNumber = 5.0f; // f denotes floating point
            double dblNumber = 5.0; // decimals are interpreted as double by default
            decimal decNumber = 5.0m; // demotes decimal number (extreme precision)
            bool boolOfTruth = true; // lowercase in C#, takes up smallest amount of memory
            string strSpecial = "This is a \"quote\" with a \nnew line and a \t tab " + "\n and another new line";
            Console.WriteLine(strSpecial);

            // Are variables objects?
            string strNumber = wholeNumber.ToString(); // They are objects, .ToString() is a method

            //Do variables have properties?
            int intLength = strSpecial.Length;




            // Keep the console open
            Console.Read();

        }
    }
}