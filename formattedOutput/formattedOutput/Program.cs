namespace formattedOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strName = "Eli";
            int intAge = 21;
            double salary = 10.5;

            Console.WriteLine("Formatted Output Demo\n");

            // Basic placeholders
            Console.WriteLine("Hello, {0}! You are {1} years old!", strName, intAge); // string parameterization
            Console.WriteLine("Hello " + strName + "!"); // string concatenation
            Console.WriteLine($"Hello {strName}! You are {intAge} years old!"); // string interpolation

            // Formatting Numbers
            Console.WriteLine("Your salary is: {0:C}", salary); // currency
            Console.WriteLine("Your salary is: {0:F}", salary); // floating point number
            Console.WriteLine("Your salary is: {0:F4}", salary); 
            Console.WriteLine("Your salary is: {0:F0}", salary);
            Console.WriteLine("Your age is {0:P}", intAge / 85.0); // percentage
            Console.WriteLine("Your age in hexadecimal is 0x{0:X}", intAge); // hexadecimal
            Console.WriteLine("This is the G format {0:G}", salary/2.99); // shortest number form
            Console.WriteLine("This is the E format {0:E2}", salary); // exponential form
            Console.WriteLine("This is the N format {0:N6}", salary); // comma seperated/formatted
            // These can all be interpolated rather than parameterized
            // ex. {salary:F} versus {0:F}

            // Date/Time
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("The current time is {0:T}", currentDate);
            Console.WriteLine("The current date is {0:d}", currentDate);

            // Alignment and Padding
            Console.WriteLine("Left-aligned:  |{0,-10}|{1,-10}|", "Name", "Age");
            Console.WriteLine("Right-aligned: |{0,10}|{1,10}|", strName, intAge);
        }
    }
}
