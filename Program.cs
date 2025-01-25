using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Wk2Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print out the prompt to ask for length input
            Console.WriteLine("Enter the length of the rectangle: ");
            //collect the user input for length
            int length = Convert.ToInt32(Console.ReadLine());

            //print out the prompt to ask for width input
            Console.WriteLine("Enter the width of the rectangle: ");
            //collect the user input for width
            int width = Convert.ToInt32(Console.ReadLine());

            //multiplie all inputs to get the area of the rectangle
            int area = length * width;
            //add length and width together, then multiplie the result by 2 to get the perimeter of the rectangle
            int perimeter = 2 * (length + width);

            //print out message saying "results"
            Console.WriteLine("Results: ");
            //print out message saying what the area is
            Console.WriteLine($"The area of the rectangle is: {area}");
            //print out message saying what the perimeter is
            Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");

            //pause screen to read output
            Console.ReadLine();
        }
    }
}
