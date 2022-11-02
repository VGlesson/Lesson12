using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            int r = Convert.ToInt32(Console.ReadLine());
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите  точку по х");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите  точку по х");
            double y = Convert.ToInt32(Console.ReadLine());
            double length = Circle.GetLength();
            double square = Circle.GetSquare();
            double center = Circle.GetCentrCircle();
            Console.WriteLine("L = {Length} S = {Square} C={Ctnter}");
            Console.ReadKey();

        }
    }
}
