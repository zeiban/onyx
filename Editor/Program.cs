using Onyx.Engine;
using SharpDX.Windows;
using System;
using System.Collections.Generic;
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
            Scene scene = new Scene
            renderer.Initialize(form);
            Entity entity = new Entity();
            Camera camera = new Camera();
            entity.AddComponent(camera);
            RenderLoop.Run(form, () =>
            {
                scene.Update()
                renderer.Update(camera);
            });

            renderer.Shutdown();
        }
    }
}
