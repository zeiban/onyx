using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine.Components
{
    public sealed class MeshReference : Component
    {
        public MeshReference() { }
        public Mesh Mesh { get; set; }

        public override void Update()
        {
        }
    }
}
