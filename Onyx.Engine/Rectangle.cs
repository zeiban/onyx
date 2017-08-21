using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine
{
    public struct Rectangle
    {
        Vector2 min;
        Vector2 max;
        public float Width { get { return max.x - min.x; } }
        public float Height { get { return max.y - min.x; } }
    }
}
