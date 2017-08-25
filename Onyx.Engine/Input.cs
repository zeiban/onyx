using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine
{
    public class Input
    {
        public static Dictionary<KeyCode, bool> keyStates = new Dictionary<KeyCode, bool>();
        public static bool GetKey(KeyCode code)
        {
            if (keyStates.TryGetValue(code, out bool state))
                return state;

            return false;
        }
    }
}
