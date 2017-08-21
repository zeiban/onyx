using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine
{
    public struct Quaternion
    {
        float X, Y, Z, W;

        public static void AxisAngle(ref Vector3 axis, float angle, out Quaternion result)
        {
            Vector3 normalized;
            Vector3.Normalize(ref axis, out normalized);

            float half = angle * 0.5f;
            float sin = (float)Math.Sin(half);
            float cos = (float)Math.Cos(half);

            result.X = normalized.X * sin;
            result.Y = normalized.Y * sin;
            result.Z = normalized.Z * sin;
            result.W = cos;
        }
    }
}
