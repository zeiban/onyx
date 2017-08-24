using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine
{
    public class Scene
    {
        private static List<Scene> scenes = new List<Scene>();
        public static IList<Scene> Scenes { get { return scenes.AsReadOnly(); } }
        public static Scene Current { get; set; }

        internal List<Entity> entities = new List<Entity>();
        public IList<Entity> Entities { get { return entities.AsReadOnly(); } }

        public Scene(string name)
        {
            if (Current == null)
                Current = this;
        }
        public void Update()
        {
            foreach (Entity entity in entities)
                entity.Update();
        }
    }
}
