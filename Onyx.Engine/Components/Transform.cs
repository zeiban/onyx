using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine.Components
{
    public sealed class Transform : Component
    {
        private Matrix localMatrix;
        public  Matrix worldMatrix;
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
        public Quaternion rotation = Quaternion.Identity;
        public Vector3 Forward
        {
            get
            {
                return worldMatrix.Forward;
            }
        }
        public Vector3 Left
        {
            get
            {
                return worldMatrix.Left;
            }
        }

        public List<Transform> children = new List<Transform>();

        public void Rotate(float x, float y, float z)
        {
            Quaternion.Euler(y, x, z, out Quaternion tmp);
            rotation *= tmp;
        }
        public override void Update()
        {
            Matrix rotationMatrix;
            Matrix translationMatrix;

            Matrix.Translation(ref position, out translationMatrix);
            Matrix.RotationQuaternion(ref rotation, out rotationMatrix);
            Matrix.Multiply(ref translationMatrix, ref rotationMatrix, out localMatrix);

            if (parent == null)
            {
                worldMatrix = localMatrix;
            } 
            else
            {
                Matrix.Multiply(ref localMatrix, ref Parent.worldMatrix, out worldMatrix);
            }
 //           Quaternion qx = new Quaternion
 //           Matrix mt = Matrix. 
 //            localMatrix = Quaternion.AxisAngle(ref Vector3.UnitX, rotation.X)  
        }
    }
}
