using System.Net.Quic;

namespace geometryCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Geometry Calculator
             * Calculates the dimensions of various shapes listed below in the block of outputs
             * Accepts user input for one or two dimensions of each shape
             * Returns all easily calculatible dimensions of those shapes
            */

            Console.WriteLine("Welcome to the Geometry Calculator!");
            // Display initial menu options, ask user for input
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Square");
            Console.WriteLine("4. Rectangle");
            Console.WriteLine("5. Irregular Polgyon");
            Console.WriteLine("6. Exit");

            Console.Write("Enter the number for the shape of your choosing: ");
            // Ask the user to pick an option
            int intChoice = Convert.ToInt32(Console.ReadLine());

            switch (intChoice)
            {
                case 1:
                    Console.WriteLine("You have chosen to calculate information for a circle"); // Radius, Area, Diameter, Circumference
                    // Display options
                    Console.WriteLine("Would you like to provide...");
                    Console.WriteLine("1. Radius");
                    Console.WriteLine("2. Diameter");
                    Console.WriteLine("3. Circumference");
                    Console.WriteLine("4. Area");
                    // Request user input
                    Console.Write("Enter a number: ");
                    int circleChoice = Convert.ToInt32(Console.ReadLine());
                    double circRadius, circDiameter, circCircumference, circArea;
                    // Calculate values
                    // Optimize by calculating radius inside switch and rest outside switch
                    switch (circleChoice)
                    {
                        case 1:
                            Console.Write("Enter the radius: ");
                            circRadius = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 2:
                            Console.Write("Enter the diameter: ");
                            circDiameter = Convert.ToDouble(Console.ReadLine());
                            circRadius = circDiameter / 2;
                            break;
                        case 3:
                            Console.Write("Enter the circumference: ");
                            circCircumference = Convert.ToDouble(Console.ReadLine());
                            circRadius = circCircumference / (2 * Math.PI);
                            break;
                        case 4:
                            Console.Write("Enter the area: ");
                            circArea = Convert.ToDouble(Console.ReadLine());
                            circRadius = Math.Sqrt(circArea / Math.PI);
                            break;
                        default:
                            Console.WriteLine("Error, bad input");
                            circRadius = 0;
                            break;
                    }

                    circDiameter = circRadius * 2;
                    circCircumference = 2 * Math.PI * circRadius;
                    circArea = Math.PI * Math.Pow(circRadius, 2);

                    // Display information

                    Console.WriteLine("A circle with radius {0} will have a diameter of {1}." +
                        "\nRadius:\t\t{0:F4}" +
                        "\nDiameter:\t{1:F4}" +
                        "\nCircumference:\t{2:F4}" +
                        "\nArea:\t\t{3}", circRadius, circDiameter, circCircumference, circArea
                        );

                    //Console.WriteLine("The radius of the circle is {0}", radius);
                    //Console.WriteLine("The diameter of the circle is {0}", diameter);
                    //Console.WriteLine("The circumference of the circle is {0}", circumference);
                    //Console.WriteLine("The area of the circle is {0}", area);

                    break;
                case 2:
                    Console.WriteLine("You have chosen to calculate information for a triangle");
                    // Variables
                    double triBase, triHeight, triArea;

                    // Input
                    Console.Write("Enter the base: ");
                    triBase = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height: ");
                    triHeight = Convert.ToDouble(Console.ReadLine());

                    // Processing
                    triArea = triBase * triHeight / 2.0;
                    Console.WriteLine("A triangle with base {0:F2} and height {1:F2} has an area of {2:F2}." + "\nBase:\t{0:F6}" + "\nHeight:\t{1:F6}" + "\nArea\t{2:F6}", triBase, triHeight, triArea);

                    // Output
                    break;
                case 3:
                    // side, area, perimeter, area, choices like circle
                    Console.WriteLine("You have chosen to calculate information for a square");
                    Console.WriteLine("Would you like to provide...");
                    Console.WriteLine("1. Side Length");
                    Console.WriteLine("2. Perimeter");
                    Console.WriteLine("3. Area");
                    Console.Write("Enter a number: "); // Prompt user
                    int squareChoice = Convert.ToInt32(Console.ReadLine());
                    // Variables
                    double sqrSide, sqrPerimeter, sqrArea;
                    switch (squareChoice)
                    {
                        case 1:
                            Console.Write("Enter the side length: ");
                            sqrSide = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 2:
                            Console.Write("Enter the perimeter: ");
                            sqrSide = (Convert.ToDouble(Console.ReadLine())) / 4;
                            break;
                        case 3:
                            Console.Write("Enter the area: ");
                            sqrSide = Math.Sqrt(Convert.ToDouble(Console.ReadLine()));
                            break;
                        default:
                            Console.WriteLine("Error: invalid input.");
                            sqrSide = 0;
                            break;
                    }
                    // Calculate perimeter and area outside switch statement to avoid redundancy
                    sqrPerimeter = sqrSide * 4;
                    sqrArea = sqrSide * sqrSide;
                    // Display stats about square
                    Console.WriteLine("A square with a side length {0:F2} has a perimeter of {1:F2} and an area of {2:F2}" +
                        "\nSide Length:\t{0:F4}" +
                        "\nPerimeter:\t{1:F4}" +
                        "\nArea:\t{2:F4}", sqrSide, sqrPerimeter, sqrArea
                        );
                    break;
                case 4:
                    // length, width, perimeter, area ( L & W -> P & A : optionally, choices)
                    Console.WriteLine("You have chosen to calculate information for a rectangle");
                    Console.WriteLine("Would you like to provide...");
                    Console.WriteLine("1. Two Side Lengths");
                    Console.WriteLine("2. One Side Length and Perimeter");
                    Console.WriteLine("3. One Side Length and Area");
                    Console.WriteLine("4. Perimeter and Area");
                    Console.Write("Enter a number: "); // prompt user
                    int rectChoice = Convert.ToInt32(Console.ReadLine());
                    double rectLength, rectWidth, rectPerimeter, rectArea; // variables
                    switch (rectChoice)
                    // Calculating each variable's value inside each case statement because of the complexity of the shape
                    {
                        case 1:
                            Console.Write("Enter the first side length: ");
                            rectLength = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the second side length: ");
                            rectWidth = Convert.ToDouble(Console.ReadLine());
                            rectPerimeter = (2 * rectLength) + (2 * rectWidth);
                            rectArea = rectLength * rectWidth;
                            break;
                        case 2:
                            Console.Write("Enter the side length: ");
                            rectLength = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the perimeter: ");
                            rectPerimeter = Convert.ToDouble(Console.ReadLine());
                            rectWidth = rectPerimeter - (2 * rectLength);
                            rectArea = rectLength * rectWidth;
                            break;
                        case 3:
                            Console.Write("Enter the side length: ");
                            rectLength = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the area: ");
                            rectArea = Convert.ToDouble(Console.ReadLine());
                            rectWidth = rectArea / rectLength;
                            rectPerimeter = (2 * rectLength) + (2 * rectWidth);
                            break;
                        case 4:
                            Console.Write("Enter the perimeter: ");
                            rectPerimeter = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the area: ");
                            rectArea = Convert.ToDouble(Console.ReadLine());
                            // Finding the length and widths by equating the formulas for perimeter and area, and then taking the roots of the systems of equations for length and width
                            if (Math.Sqrt((Math.Pow((-1 * rectPerimeter / 2),2) - 4 * rectArea)) >= 0) // error checking for nonreal roots
                            {
                                rectLength = ((rectPerimeter / 2) - Math.Sqrt((Math.Pow((-1 * rectPerimeter / 2), 2) - 4 * rectArea))) / 2;
                                rectWidth = ((rectPerimeter / 2) + Math.Sqrt((Math.Pow((-1 * rectPerimeter / 2), 2) - 4 * rectArea))) / 2;
                            }
                            else
                            {
                                Console.WriteLine("A rectangle with perimeter {0} and area {1} does not exist.", rectPerimeter, rectArea);
                                // Make it obvious that this rectangle isn't real
                                rectLength = -1;
                                rectWidth = -1;
                                break;
                            }
                            break;
                        default:
                            Console.WriteLine("Error.");
                            rectLength = 0;
                            rectWidth = 0;
                            rectPerimeter = 0;
                            rectArea = 0;
                            break;
                    }
                    if (rectLength > 0) // conditional to not show statistics for rectangles that don't exist
                    {
                        Console.WriteLine("A rectangle with length {0} and width {1} has a perimeter of {2} and an area of {3}", rectLength, rectWidth, rectPerimeter, rectArea);
                        Console.WriteLine("Length:\t\t{0}" +
                            "\nWidth:\t\t{1}" +
                            "\nPerimeter:\t{2}" +
                            "\nArea:\t\t{3}", rectLength, rectWidth, rectPerimeter, rectArea
                            );
                    }
                    break;
                case 5:
                    // Make a funny error message about how this is too hard
                    Console.WriteLine("You have chosen to calculate information for a irregular polygon\n");
                    Console.Write("Thinking...");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("I give up.");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            // Restart the program back at the beginning - Add some lines/dividers to make this look better


            Main(args);

        }
    }
}
