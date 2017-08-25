using Onyx.Engine;
using Onyx.Engine.Components;
using SharpDX.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Screen = Onyx.Engine.Screen;

namespace Onyx.Editor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public class MyComponent : Component
        {
            public override void Update()
            {
            }
        }

        [STAThread]
        static void Main()
        {
            var form = new RenderForm("Onyx");
            form.Resize += (sender, args) =>
            {
                Screen.Width = form.ClientSize.Width;
                Screen.Height = form.ClientSize.Height;
            };
            form.ClientSize = new System.Drawing.Size(640, 480);
            D3D11Renderer renderer = new D3D11Renderer();
            Scene scene = new Scene("My Scene");
            renderer.Initialize(form);
            Entity entity;
            entity = new Entity();
            Camera camera = entity.AddComponent<Camera>();
            entity.Transform.position = new Vector3(0.0f, 0.0f, 15.0f);

            //entity = Entity.CreatePrimitive(PrimitiveType.Cube);

            form.KeyDown += (sender, args) =>
            {
                Debug.WriteLine($" Down {args.KeyValue}");
                Input.keyStates[(KeyCode)args.KeyCode] = true;
            };

            form.KeyUp += (sender, args) =>
            {
                Debug.WriteLine($" Up {args.KeyValue}");
                Input.keyStates[(KeyCode)args.KeyCode] = false;
            };

            RenderLoop.Run(form, () =>
            {
                if (Input.GetKey(KeyCode.Left))
                {
                    entity.Transform.Rotate(0.0f, 0.00005f, 0.0f);
                }
                if (Input.GetKey(KeyCode.Right))
                {
                    entity.Transform.Rotate(0.0f, -0.00005f, 0.0f);
                }
                if (Input.GetKey(KeyCode.Up))
                {
                    entity.Transform.Rotate(0.00005f, 0.0f, 0.0f);
                }
                if (Input.GetKey(KeyCode.Down))
                {
                    entity.Transform.Rotate(-0.00005f, 0.0f, 0.0f);
                }

                if (Input.GetKey(KeyCode.W))
                {
                    Debug.WriteLine($"Forward");
                    entity.Transform.position += -entity.Transform.Forward * 0.005f;
                }

                if (Input.GetKey(KeyCode.S))
                {
                    Debug.WriteLine($"Backward");
                    entity.Transform.position += entity.Transform.Forward * 0.005f;
                }

                if (Input.GetKey(KeyCode.A))
                {
                    Debug.WriteLine($"Left");
                    entity.Transform.position += -entity.Transform.Left * 0.005f;
                }

                if (Input.GetKey(KeyCode.D))
                {
                    Debug.WriteLine($"Right");
                    entity.Transform.position += entity.Transform.Left * 0.005f;
                }

                scene.Update();
                renderer.Update(camera);
            });

            renderer.Shutdown();
        }
    }
}
