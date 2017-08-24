using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine
{
    public class Mesh
    {
        public Vector3[] Vertices {get; set;}
        public Color4[] Colors { get; set; }
        public Vector2[] UV { get; set; }
        public UInt32[] Indices { get; set; }
    }
}
