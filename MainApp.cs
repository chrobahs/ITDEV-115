/*
Programmer: Skylar Chrobak
*/

using System;
using SYstem.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProblem
{
    class Program {
        static void Main(string[] args)
        {
            string tempVariable;
            double height;
            double width;
            double area;
            double perimeter;

            DisplayInfo("Rectangle Assignment");
            Console.Read();
            Console.WriteLine("\nThis program will calculate the area and the perimeter of a rectangle.");
            Console.WriteLine("All you need is to enter the rectangle's height and width.");

            Console.WriteLine("Please enter the rectangle's height in inches: ");
            tempVariable = Console.ReadLine(); //user enters the height
            height = double.Parse(tempVariable);

            Console.WriteLine("Please enter the rectangle's width in inches: ");
            tempVariable = Console.ReadLine(); //user enters the width
            width = double.Parse(tempVariable);

            area = CalculateArea(height, width);
            perimeter = CalculatePerimeter(height, width); 

            Console.WriteLine("/nThe area of the rectangle is (0:N1) square inches", area);
            Console.WriteLine("The perimeter of the rectangle is (0:N1) inches", perimeter);

            Console.ReadKey();
        }
        static double CalculateArea(double ht, double wdth){
            double aArea;
            aArea = ht * wdth;
            return aArea;
        }
        public static CalculatePerimeter( double hit, double with){
            double peri;
            peri = (with + hit)*2;
            return peri;

        }
        static void DisplayInfo(string assignment){
            string aHeader = "***************************/n";
            Console.WriteLine(aHeader);
            Console.WriteLine("Skylar Chrobak");
            Console.WriteLine("ITDEV-115 - Mr. Menzl");
            Console.WriteLine(System.DateTime.Today.ToShortDateString()); 
            Console.WriteLine(aHeader);
            Console.WriteLine("The area of the rectangle is: ");
            Console.WriteLine("The perimeter of the rectangle is: ");

        }
    }
    
    
}