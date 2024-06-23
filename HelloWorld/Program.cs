using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable declaration
            double height = 0;
            double width = 0;
            double perimeter = 0;
            double area = 0;


            //1.Ask for rectangle height
            Console.Write("height? ");
            height = Convert.ToDouble(Console.ReadLine());

            // 2.Ask for rectangle width
            Console.Write("width? ");
            width = Convert.ToDouble(Console.ReadLine());

            //3.calculate area multiplied by height times width
            area = height * width;

            //4.calculate the perimeter by adding the four sides together
            perimeter = 2 * (width + height);

            //5.show area
            Console.WriteLine("The area is: " + area);

            //6.show perimeter
            Console.WriteLine("The perimeter is: " + perimeter);


        }
    }
}
