using System;

namespace Shape_Area_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            float result;

            while (true)
            {
                Console.WriteLine("What shape would you like to find the area of?");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Square");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Circle");
                Console.WriteLine("5. Parallelogram");
                Console.WriteLine("6. Trapezoid");
                Console.WriteLine("7. Ellipse");
                Console.WriteLine("8. Rhombus");
                Console.WriteLine("9. Sector of a circle");
                Console.WriteLine("10. Annulus");
                Console.WriteLine("11. Kite");
                Console.WriteLine("12. Exit");
                Console.Write("Please select one: ");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 12)
                {
                    Console.WriteLine("Thanks for using our app!");
                    break;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter length:");
                        float length = float.Parse(Console.ReadLine());

                        Console.WriteLine("Enter width:");
                        float width = float.Parse(Console.ReadLine());

                        result = length * width;
                        Console.WriteLine("Result: " + result);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter side:");
                        float side = float.Parse(Console.ReadLine());

                        result = (float)Math.Pow(side, 2);
                        Console.WriteLine("Result: " + result);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter base:");
                        float baseTriangle = float.Parse(Console.ReadLine());

                        Console.WriteLine("Enter height:");
                        float heightTriangle = float.Parse(Console.ReadLine());

                        result = 1/2*baseTriangle*heightTriangle;
                        Console.WriteLine("Result: " + result);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter radius:");
                        float radius = float.Parse(Console.ReadLine());

                        result =(float)(Math.PI*Math.Pow(radius, 2));
                        Console.WriteLine("Result: " + result);
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Enter base:");
                        float basePara = float.Parse(Console.ReadLine());

                        Console.WriteLine("Enter height:");
                        float heightPara = float.Parse(Console.ReadLine());

                        result = basePara*heightPara;
                        Console.WriteLine("Result: " + result);
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("Enter base1:");
                        float base1 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Enter base2:");
                        float base2 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Enter height:");
                        float heighttrap = float.Parse(Console.ReadLine());

                        result = 1/2*(base1+base2)*heighttrap;
                        Console.WriteLine("Result: " + result);
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine("Enter semi-major axis:");
                        float semi_major = float.Parse(Console.ReadLine());

                        Console.WriteLine("Enter semi-minor axis:");
                        float semi_minor = float.Parse(Console.ReadLine());

                        result = (float)(Math.PI*semi_major*semi_minor);
                        Console.WriteLine("Result: " + result);
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.WriteLine("Enter diagonal1:");
                        float dia1 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Enter diagonal2:");
                        float dia2 = float.Parse(Console.ReadLine());

                        result = 1/2*dia1*dia2;
                        Console.WriteLine("Result: " + result);
                        Console.WriteLine();
                        break;
                    case 9:
                        Console.WriteLine("Enter radius:");
                        float radiusSector = float.Parse(Console.ReadLine());

                        Console.WriteLine("Enter angle in radians:");
                        float angle = float.Parse(Console.ReadLine());

                        result = (float)(1/2*Math.Pow(radiusSector, 2)*angle);
                        Console.WriteLine("Result: " + result);
                        Console.WriteLine();
                        break;
                    case 10:
                        Console.WriteLine("Enter outer radius:");
                        float outer = float.Parse(Console.ReadLine());

                        Console.WriteLine("Enter inner radius:");
                        float inner = float.Parse(Console.ReadLine());

                        result = (float)(Math.PI*Math.Pow(outer, 2)+Math.Pow(inner,2));
                        Console.WriteLine("Result: " + result);
                        Console.WriteLine();
                        break;
                    case 11:
                        Console.WriteLine("Enter diagonal1:");
                        float diago1 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Enter diagonal2:");
                        float diago2 = float.Parse(Console.ReadLine());

                        result = 1/2*diago1*diago2;
                        Console.WriteLine("Result: " + result);
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please select a valid option.");
                        break;
                }
            }

        }
    }
}
