using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine
{
    public abstract class Component
    {
        public Entity entity { get; set; }
        public abstract void Update();
    }
}
