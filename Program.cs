using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaration of variables
            float x1 = 0, y1 = 0, x2 = 0, y2 = 0, x = 0, y = 0;
            double pytha = 0, radian = 0, grade = 0;
            const double RAD_GRAD = 180 / Math.PI;
            // welcome words
            Console.WriteLine("Welcome, this application calculates");
            Console.WriteLine("the distance between two points,");
            Console.WriteLine("and the angle in which it is located.");
            Console.WriteLine();
            // Point 1 parameters
            Console.Write("write the value of point 1 in x: ");
            x1 = float.Parse(Console.ReadLine());
            Console.Write("write the value of point 1 in y: ");
            y1 = float.Parse(Console.ReadLine());
            // Point 2 parameters
            Console.Write("write the value of point 2 in x: ");
            x2 = float.Parse(Console.ReadLine());
            Console.Write("write the value of point 2 in y: ");
            y2 = float.Parse(Console.ReadLine());
            // X and y total
            x = x2 - x1;
            y = y2 - y1;

            //Pythagoras theorem
            pytha = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));
            //Calculate in radian
            radian = Math.Atan2(y , x);
            //Convert radians to degrees
            grade = radian * RAD_GRAD;

            Console.WriteLine("The distance from point 1 to point 2 is: " + pytha.ToString("F3"));
            Console.WriteLine("The angle is: " + grade.ToString("F3") + "°");
            Console.WriteLine();




        }
    }
}
