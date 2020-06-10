using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class DevMath
    {
        public static float Lerp(float a, float b, float t)
        {
            return a * (1 - t) + b * t;
        }

        public static float DistanceTraveled(float startVelocity, float acceleration, float time)
        {
            //d = V*T + 0.5 * a * Math.Pow(time,2);
            return startVelocity * time + 0.5f * acceleration * (float)Math.Pow(time, 2);
        }

        public static float Clamp(float value, float min, float max)
        {
            if (value < min)
                value = min;
            if (value > max)
                value = max;

            return value;
        }

        public static float RadToDeg(float angle)
        {
            return (float)(angle * 57.29578f);
        }

        public static float DegToRad(float angle)
        {
            return (float)(angle * 0.0174532924f);
        }
    }
}
