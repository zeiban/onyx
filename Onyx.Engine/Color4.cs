using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct Color4
    {
        public float R;
        public float G;
        public float B;
        public float A;

        public Color4(float R, float G, float B, float A)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            this.A = A;
        }
    }
}
