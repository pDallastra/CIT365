using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            //Part I
            //Declaring Variables
            string name = "Paulo";
            string location = "Brazil";

            //Prompt the values and a few texts.
            Console.WriteLine("My name is " + name + ", I am from " + location);
            Console.WriteLine("Today is " + DateTime.Now.ToString("MM/dd/yyyy"));
            //Console.WriteLine($"Today is {DateTime.Now.ToString("MM/dd/yyyy")}"); testing 

            //Get the time and do the math for Xmas
            DateTime today = DateTime.Today;
            DateTime xMas = new DateTime(today.Year, 12, 25);
            int result = (xMas - today).Days;

            //Prompt the result for the math
            Console.WriteLine("We have " + result + " days left until Chrystmas");

            //Part II

            //Declaring Variables
            double width, height, woodLength, glassArea; string widthString, heightString;

            //Prompt for/get the Width from user
            Console.Write("Please Enter the Width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            //Prompt for/get the Height from user
            Console.Write("Please Enter the Height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            //Doing the math for woodLenght and glassArea
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            //Displaying the result
            Console.WriteLine("The length of the wood is " + woodLength + " feet"); Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            //Letting the user know that it needs to press a key to close
            Console.WriteLine("\nPress any key to close the window...");
            Console.ReadKey();
        }
    }
}