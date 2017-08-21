using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine
{
    public class Transform : IComponent
    {
        private Matrix localMatrix;
        private Matrix worldMatrix;
        private Transform parent = null;
        public Transform Parent
        {
            get { return parent; }
            set
            {
                if(parent != null)
                {
                    if (parent.children.Contains(this))
                    {
                        parent.children.Remove(this);
                    }
                }
                parent = value;
            }
        }
        public Vector3 position;
        public Vector3 rotation;
        public List<Transform> children = new List<Transform>();
        public void Update()
        {
 //           Quaternion qx = new Quaternion
 //           Matrix mt = Matrix. 
//            localMatrix = Quaternion.AxisAngle(ref Vector3.UnitX, rotation.X)  
        }
    }
}
