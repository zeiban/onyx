using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine
{
    public class Entity
    {
        public static CreatePrimitive()
        public List<Component> components = new List<Component>();
        public Transform transform = new Transform();
        public Entity()
        {
            components.Add(this.transform);
        }
        public void AddComponent(Component component)
        {
            component.entity = this;
            components.Add(component);
        }
        void Update()
        {
            foreach(var component in components)
            {
                component.Update();
            }
        }
    }
}
