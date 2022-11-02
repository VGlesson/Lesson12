using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    static class Circle
    {
        static public double GetLength(int r = 0)
        {
            return 2 * Math.PI * r;
        }
        static public double GetSquare(int r = 0)
        {
            return Math.PI * r * r;
        }
        static public double GetCentrCircle(double x = 0, double y = 0, int r = 0, double a, double b);
        {
        return (x-a)*2(y-b)*2=r*2;
        }
    } 
}
