using Onyx.Engine.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onyx.Engine
{
    interface Renderer
    {
        bool Initialize(Form form);
        void Update(Camera camera);
        void Shutdown();
    }
}
