﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine
{
    public abstract class Component
    {
        public Entity Entity { get; internal set; }
        public abstract void Update();
    }
}
