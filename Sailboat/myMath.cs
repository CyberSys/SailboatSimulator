using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailboat
{
    class myMath
    {
        public static double DegreesToRadians(double Degrees)
        {
            double radians = (Degrees / 180) * Math.PI;
            return Wrap(radians, 2 * Math.PI);
        }
        public static double RadiansToDegrees(double Radians)
        {
            double degrees = (Radians / Math.PI) * 180;
            return Wrap(degrees, 360);
        }
        public static double Wrap(double input, double length)
        {
            input %= length;
            if (input < 0)
                input += length;
            return input;
        }
    }
}
