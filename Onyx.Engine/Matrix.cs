using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct Matrix
    {
        public float M11, M12, M13, M14;
        public float M21, M22, M23, M24;
        public float M31, M32, M33, M34;
        public float M41, M42, M43, M44;

        public static readonly Matrix Identity = new Matrix() { M11 = 1.0f, M22 = 1.0f, M33 = 1.0f, M44 = 1.0f };

        public static void Translation(float x, float y, float z, out Matrix result)
        {
            result = Matrix.Identity;
            result.M41 = x;
            result.M42 = y;
            result.M43 = z;
        }

        public static void Translation(ref Vector3 value, out Matrix result)
        {
            Translation(value.X, value.Y, value.Z, out result);
        }

        public static Matrix Translation(Vector3 value)
        {
            Matrix result;
            Translation(ref value, out result);
            return result;
        }

        public static void Multiply(ref Matrix left, ref Matrix right, out Matrix result)
        {
            Matrix temp = new Matrix();
            temp.M11 = (left.M11 * right.M11) + (left.M12 * right.M21) + (left.M13 * right.M31) + (left.M14 * right.M41);
            temp.M12 = (left.M11 * right.M12) + (left.M12 * right.M22) + (left.M13 * right.M32) + (left.M14 * right.M42);
            temp.M13 = (left.M11 * right.M13) + (left.M12 * right.M23) + (left.M13 * right.M33) + (left.M14 * right.M43);
            temp.M14 = (left.M11 * right.M14) + (left.M12 * right.M24) + (left.M13 * right.M34) + (left.M14 * right.M44);
            temp.M21 = (left.M21 * right.M11) + (left.M22 * right.M21) + (left.M23 * right.M31) + (left.M24 * right.M41);
            temp.M22 = (left.M21 * right.M12) + (left.M22 * right.M22) + (left.M23 * right.M32) + (left.M24 * right.M42);
            temp.M23 = (left.M21 * right.M13) + (left.M22 * right.M23) + (left.M23 * right.M33) + (left.M24 * right.M43);
            temp.M24 = (left.M21 * right.M14) + (left.M22 * right.M24) + (left.M23 * right.M34) + (left.M24 * right.M44);
            temp.M31 = (left.M31 * right.M11) + (left.M32 * right.M21) + (left.M33 * right.M31) + (left.M34 * right.M41);
            temp.M32 = (left.M31 * right.M12) + (left.M32 * right.M22) + (left.M33 * right.M32) + (left.M34 * right.M42);
            temp.M33 = (left.M31 * right.M13) + (left.M32 * right.M23) + (left.M33 * right.M33) + (left.M34 * right.M43);
            temp.M34 = (left.M31 * right.M14) + (left.M32 * right.M24) + (left.M33 * right.M34) + (left.M34 * right.M44);
            temp.M41 = (left.M41 * right.M11) + (left.M42 * right.M21) + (left.M43 * right.M31) + (left.M44 * right.M41);
            temp.M42 = (left.M41 * right.M12) + (left.M42 * right.M22) + (left.M43 * right.M32) + (left.M44 * right.M42);
            temp.M43 = (left.M41 * right.M13) + (left.M42 * right.M23) + (left.M43 * right.M33) + (left.M44 * right.M43);
            temp.M44 = (left.M41 * right.M14) + (left.M42 * right.M24) + (left.M43 * right.M34) + (left.M44 * right.M44);
            result = temp;
        }

        public static void Multiply(ref Matrix left, float right, out Matrix result)
        {
            result.M11 = left.M11 * right;
            result.M12 = left.M12 * right;
            result.M13 = left.M13 * right;
            result.M14 = left.M14 * right;
            result.M21 = left.M21 * right;
            result.M22 = left.M22 * right;
            result.M23 = left.M23 * right;
            result.M24 = left.M24 * right;
            result.M31 = left.M31 * right;
            result.M32 = left.M32 * right;
            result.M33 = left.M33 * right;
            result.M34 = left.M34 * right;
            result.M41 = left.M41 * right;
            result.M42 = left.M42 * right;
            result.M43 = left.M43 * right;
            result.M44 = left.M44 * right;
        }
        public static void RotationX(float angle, out Matrix result)
        {
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);

            result = Matrix.Identity;
            result.M22 = cos;
            result.M23 = sin;
            result.M32 = -sin;
            result.M33 = cos;
        }

        /// <summary>
        /// Creates a matrix that rotates around the x-axis.
        /// </summary>
        /// <param name="angle">Angle of rotation in radians. Angles are measured clockwise when looking along the rotation axis toward the origin.</param>
        /// <returns>The created rotation matrix.</returns>
        public static Matrix RotationX(float angle)
        {
            Matrix result;
            RotationX(angle, out result);
            return result;
        }

        /// <summary>
        /// Creates a matrix that rotates around the y-axis.
        /// </summary>
        /// <param name="angle">Angle of rotation in radians. Angles are measured clockwise when looking along the rotation axis toward the origin.</param>
        /// <param name="result">When the method completes, contains the created rotation matrix.</param>
        public static void RotationY(float angle, out Matrix result)
        {
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);

            result = Matrix.Identity;
            result.M11 = cos;
            result.M13 = -sin;
            result.M31 = sin;
            result.M33 = cos;
        }

        public static Matrix RotationY(float angle)
        {
            Matrix result;
            RotationY(angle, out result);
            return result;
        }

        public static void RotationZ(float angle, out Matrix result)
        {
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);

            result = Matrix.Identity;
            result.M11 = cos;
            result.M12 = sin;
            result.M21 = -sin;
            result.M22 = cos;
        }

        public static Matrix RotationZ(float angle)
        {
            Matrix result;
            RotationZ(angle, out result);
            return result;
        }

        public static void PerspectiveFovLH(float fov, float aspect, float znear, float zfar, out Matrix result)
        {
            float yScale = (float)(1.0f / Math.Tan(fov * 0.5f));
            float q = zfar / (zfar - znear);

            result = new Matrix();
            result.M11 = yScale / aspect;
            result.M22 = yScale;
            result.M33 = q;
            result.M34 = 1.0f;
            result.M43 = -q * znear;
        }

        public static Matrix PerspectiveFovLH(float fov, float aspect, float znear, float zfar)
        {
            Matrix result;
            PerspectiveFovLH(fov, aspect, znear, zfar, out result);
            return result;
        }

        public static Matrix operator *(Matrix left, Matrix right)
        {
            Matrix result;
            Multiply(ref left, ref right, out result);
            return result;
        }

        public static void Transpose(ref Matrix value, out Matrix result)
        {
            Matrix temp = new Matrix();
            temp.M11 = value.M11;
            temp.M12 = value.M21;
            temp.M13 = value.M31;
            temp.M14 = value.M41;
            temp.M21 = value.M12;
            temp.M22 = value.M22;
            temp.M23 = value.M32;
            temp.M24 = value.M42;
            temp.M31 = value.M13;
            temp.M32 = value.M23;
            temp.M33 = value.M33;
            temp.M34 = value.M43;
            temp.M41 = value.M14;
            temp.M42 = value.M24;
            temp.M43 = value.M34;
            temp.M44 = value.M44;

            result = temp;
        }

        public static void RotationQuaternion(ref Quaternion rotation, out Matrix result)
        {
            float xx = rotation.X * rotation.X;
            float yy = rotation.Y * rotation.Y;
            float zz = rotation.Z * rotation.Z;
            float xy = rotation.X * rotation.Y;
            float zw = rotation.Z * rotation.W;
            float zx = rotation.Z * rotation.X;
            float yw = rotation.Y * rotation.W;
            float yz = rotation.Y * rotation.Z;
            float xw = rotation.X * rotation.W;

            result = Matrix.Identity;
            result.M11 = 1.0f - (2.0f * (yy + zz));
            result.M12 = 2.0f * (xy + zw);
            result.M13 = 2.0f * (zx - yw);
            result.M21 = 2.0f * (xy - zw);
            result.M22 = 1.0f - (2.0f * (zz + xx));
            result.M23 = 2.0f * (yz + xw);
            result.M31 = 2.0f * (zx + yw);
            result.M32 = 2.0f * (yz - xw);
            result.M33 = 1.0f - (2.0f * (yy + xx));
        }

        public void Transpose()
        {
            Transpose(ref this, out this);
        }

        public Vector3 Forward
        {
            get
            {
                Vector3 v;
                v.X = M31;
                v.Y = M32;
                v.Z = M33;
                return v;
            }
        }
        public Vector3 Left
        {
            get
            {
                Vector3 v;
                v.X = -M11;
                v.Y = -M12;
                v.Z = -M13;
                return v;
            }
        }
    }
}
