using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine.Components
{
    public sealed class MeshRenderer : Component
    {
        public MeshRenderer() { }
        private MeshReference meshRef;
        public override void Update()
        {
            meshRef = Entity.GetComponent<MeshReference>();
        }
    }
}
