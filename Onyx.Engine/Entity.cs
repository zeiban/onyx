using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine
{
    public class Entity
    {
        public List<IComponent> components = new List<IComponent>();
        public Transform transform = new Transform();
        public Entity()
        {
            components.Add(this.transform);
        }
        public void AddComponent(IComponent component)
        {
            component.Parent = this;
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
