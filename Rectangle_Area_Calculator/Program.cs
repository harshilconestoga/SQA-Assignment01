using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Area_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool choice = false;
            int menu_item;
            Console.WriteLine("Rectangle area & perimeter calculator");
            try
            {
                Rectangle rect = new Rectangle();
                while (true)
                {
                    do
                    {
                        Console.WriteLine("Rectangle is " + rect.GetLength() + "x" + rect.GetWidth() + "\n");
                        Console.WriteLine("User Menu:");
                        Console.WriteLine("1.Get Rectangle Length \n2.Change Rectangle Length \n3.Get Rectangle Width \n4.Change Rectangle Width \n5. Get Rectangle Perimeter \n6. Get Rectangle Area \n7. Exit");
                        Console.WriteLine("Enter your choice: ");
                        menu_item = Convert.ToInt32(Console.ReadLine());
                        if (menu_item >= 1 && menu_item <= 7)
                        {
                            choice = true;
                        }
                        else
                        {
                            Console.WriteLine("Please provide a valid input!");
                        }
                    } while (choice == false);


                    switch (menu_item)
                    {
                        case 1:
                            Console.WriteLine("The length of rectangle is: " + rect.GetLength());
                            break;

                        case 2:
                            Console.WriteLine("Enter length of rectangle: ");
                            int length = Convert.ToInt32(Console.ReadLine());
                            if (length > 0)
                            {
                                rect.SetLength(length);
                            }
                            else
                            {
                                Console.WriteLine("Length cannot be empty");
                            }
                            Console.WriteLine("\n");
                            break;

                        case 3:
                            Console.WriteLine("The width of rectangle is: " + rect.GetWidth());
                            break;

                        case 4:
                            Console.WriteLine("Enter width of rectangle: ");
                            int width = Convert.ToInt32(Console.ReadLine());
                            rect.SetWidth(width);
                            if (width > 0)
                            {
                                rect.SetWidth(width);
                            }
                            else
                            {
                                Console.WriteLine("Length cannot be empty");
                            }
                            Console.WriteLine("\n");
                            break;

                        case 5:
                            Console.WriteLine("Perimeter of rectangle is: " + rect.GetPerimeter());
                            break;

                        case 6:
                            Console.WriteLine("Area of rectangle is: " + rect.GetArea());
                            break;

                        case 7:
                            Environment.Exit(0);
                            break;
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Invalid input \nProgram will now exit");
            }

            Console.ReadLine();
        }
    }
}
