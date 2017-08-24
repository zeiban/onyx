using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine
{
    public abstract class Component
    {
        internal Entity entity;
        public Entity Entity { get { return entity; } }
        public abstract void Update();
    }
}
