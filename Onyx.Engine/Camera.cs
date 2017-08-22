using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine
{
    public class Camera : IComponent
    {
        internal static Camera current;
        public static Camera Current { get { return current; } }
        public float nearClipPlane = 0.1f;
        public float farClipPlane = 100.0f;
        public float aspect;
        public Matrix projectionMatrix;
        public Rectangle location;
        public Camera()
        {
            if (current != null)
                Camera.current = this;
        }
        public override void Update()
        {
            Matrix.PerspectiveFovLH((float)Math.PI / 4.0f, Screen.Width / (float)Screen.Height, nearClipPlane, farClipPlane, out projectionMatrix);
        }
    }
}
