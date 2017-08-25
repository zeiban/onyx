using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct Vector3
    {
        public float X;
        public float Y;
        public float Z;
        public static readonly Vector3 UnitX = new Vector3(1.0f, 0.0f, 0.0f);
        public static readonly Vector3 UnitY = new Vector3(0.0f, 1.0f, 0.0f);
        public static readonly Vector3 UnitZ = new Vector3(0.0f, 0.0f, 1.0f);

        public Vector3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public float Length()
        {
            return (float)Math.Sqrt((X * X) + (Y * Y) + (Z * Z));
        }

        public void Normalize()
        {
            float length = Length();
//            if (!MathUtil.IsZero(length))
//            {
                float inv = 1.0f / length;
                X *= inv;
                Y *= inv;
                Z *= inv;
//            }
        }

        public static void Normalize(ref Vector3 value, out Vector3 result)
        {
            result = value;
            result.Normalize();
        }
        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
            
        }
        public static Vector3 operator *(Vector3 v, float f)
        {
            return new Vector3(v.X * f, v.Y * f, v.Z * f);
        }
        public static Vector3 operator -(Vector3 v)
        {
            return new Vector3(-v.X, -v.Y, -v.Z);
        }
    }
}
