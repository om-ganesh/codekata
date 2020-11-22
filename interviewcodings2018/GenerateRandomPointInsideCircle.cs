using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewcodings2018
{
    /// <summary>
    /// Given a function Rand() which gives random floating point between 0 and 1
    /// A circle exists with center cx,cy and radius r
    /// Create a function to generate a point within a function
    /// </summary>
    public class GenerateRandomPointInsideCircle
    {
        public static void Init()
        {
            PointXY pointXY = GetPointInsideCircle(0, 0, 2);
            Console.WriteLine(pointXY.ToString());
        }

        public static PointXY GetPointInsideCircle(int centerX, int centerY, int radius)
        {
            PointXY point = new PointXY();

            float x = Mapper(Rand(), radius);
            float y = Mapper(Rand(), radius);

            if ((x * x + y * y) < radius * radius)
            {
                point.x = x + centerX;
                point.y = y + centerY;
            }
            else
            {
                point = GetPointInsideCircle(centerX, centerY, radius);
            }

            return point;

            float Rand()
            {
                return (float)new Random().NextDouble();
            }

            float Mapper(float number, int range)
            {
                return number * 2 * range - range;
            }
        }

        public class PointXY
        {
            public float x { get; set; }
            public float y { get; set; }

            public override string ToString()
            {
                return $"(x,y): ({x},{y})";
            }

        }
    }
}
