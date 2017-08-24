using Onyx.Engine.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Engine
{
    public sealed class Entity
    {
        
        public static Entity CreatePrimitive(PrimitiveType type)
        {
            Entity entity = new Entity();
            MeshReference meshRef = entity.AddComponent<MeshReference>();
            Mesh mesh = meshRef.Mesh = new Mesh();
            mesh.Vertices = new[] 
            {
                new Vector3(-1.0f, -1.0f, -1.0f), //Front
                new Vector3(-1.0f,  1.0f, -1.0f),
                new Vector3( 1.0f,  1.0f, -1.0f),
                new Vector3(-1.0f, -1.0f, -1.0f),
                new Vector3( 1.0f,  1.0f, -1.0f),
                new Vector3( 1.0f, -1.0f, -1.0f),

                new Vector3(-1.0f, -1.0f, 1.0f), //Back
                new Vector3( 1.0f,  1.0f, 1.0f),
                new Vector3(-1.0f,  1.0f, 1.0f),
                new Vector3(-1.0f, -1.0f, 1.0f),
                new Vector3( 1.0f, -1.0f, 1.0f),
                new Vector3( 1.0f,  1.0f, 1.0f),

                new Vector3(-1.0f, 1.0f, -1.0f), // Top
                new Vector3(-1.0f, 1.0f,  1.0f),
                new Vector3( 1.0f, 1.0f,  1.0f),
                new Vector3(-1.0f, 1.0f, -1.0f),
                new Vector3( 1.0f, 1.0f,  1.0f),
                new Vector3( 1.0f, 1.0f, -1.0f),

                new Vector3(-1.0f,-1.0f, -1.0f), // Bottom
                new Vector3( 1.0f,-1.0f,  1.0f),
                new Vector3(-1.0f,-1.0f,  1.0f),
                new Vector3(-1.0f,-1.0f, -1.0f),
                new Vector3( 1.0f,-1.0f, -1.0f),
                new Vector3( 1.0f,-1.0f,  1.0f),

                new Vector3(-1.0f, -1.0f, -1.0f), // Left
                new Vector3(-1.0f, -1.0f,  1.0f),
                new Vector3(-1.0f,  1.0f,  1.0f),
                new Vector3(-1.0f, -1.0f, -1.0f),
                new Vector3(-1.0f,  1.0f,  1.0f),
                new Vector3(-1.0f,  1.0f, -1.0f),

                new Vector3( 1.0f, -1.0f, -1.0f), // right
                new Vector3( 1.0f,  1.0f,  1.0f),
                new Vector3( 1.0f, -1.0f,  1.0f),
                new Vector3( 1.0f, -1.0f, -1.0f),
                new Vector3( 1.0f,  1.0f, -1.0f),
                new Vector3( 1.0f,  1.0f,  1.0f),
            };

            mesh.Colors = new[]
            {
                new Color4(1.0f, 0.0f, 0.0f, 1.0f),
                new Color4(1.0f, 0.0f, 0.0f, 1.0f),
                new Color4(1.0f, 0.0f, 0.0f, 1.0f),
                new Color4(1.0f, 0.0f, 0.0f, 1.0f),
                new Color4(1.0f, 0.0f, 0.0f, 1.0f),
                new Color4(1.0f, 0.0f, 0.0f, 1.0f),

                new Color4(0.0f, 1.0f, 0.0f, 1.0f),
                new Color4(0.0f, 1.0f, 0.0f, 1.0f),
                new Color4(0.0f, 1.0f, 0.0f, 1.0f),
                new Color4(0.0f, 1.0f, 0.0f, 1.0f),
                new Color4(0.0f, 1.0f, 0.0f, 1.0f),
                new Color4(0.0f, 1.0f, 0.0f, 1.0f),

                new Color4(0.0f, 0.0f, 1.0f, 1.0f),
                new Color4(0.0f, 0.0f, 1.0f, 1.0f),
                new Color4(0.0f, 0.0f, 1.0f, 1.0f),
                new Color4(0.0f, 0.0f, 1.0f, 1.0f),
                new Color4(0.0f, 0.0f, 1.0f, 1.0f),
                new Color4(0.0f, 0.0f, 1.0f, 1.0f),

                new Color4(1.0f, 1.0f, 0.0f, 1.0f),
                new Color4(1.0f, 1.0f, 0.0f, 1.0f),
                new Color4(1.0f, 1.0f, 0.0f, 1.0f),
                new Color4(1.0f, 1.0f, 0.0f, 1.0f),
                new Color4(1.0f, 1.0f, 0.0f, 1.0f),
                new Color4(1.0f, 1.0f, 0.0f, 1.0f),

                new Color4(1.0f, 0.0f, 1.0f, 1.0f),
                new Color4(1.0f, 0.0f, 1.0f, 1.0f),
                new Color4(1.0f, 0.0f, 1.0f, 1.0f),
                new Color4(1.0f, 0.0f, 1.0f, 1.0f),
                new Color4(1.0f, 0.0f, 1.0f, 1.0f),
                new Color4(1.0f, 0.0f, 1.0f, 1.0f),

                new Color4(0.0f, 1.0f, 1.0f, 1.0f),
                new Color4(0.0f, 1.0f, 1.0f, 1.0f),
                new Color4(0.0f, 1.0f, 1.0f, 1.0f),
                new Color4(0.0f, 1.0f, 1.0f, 1.0f),
                new Color4(0.0f, 1.0f, 1.0f, 1.0f),
                new Color4(0.0f, 1.0f, 1.0f, 1.0f)
            };

            MeshRenderer meshRenderer = entity.AddComponent<MeshRenderer>();

            return entity;
            /*
new[]
                                  {
                                      new Vector4(-1.0f, -1.0f, -1.0f, 1.0f), new Vector4(1.0f, 0.0f, 0.0f, 1.0f), // Front
                                      new Vector4(-1.0f,  1.0f, -1.0f, 1.0f), new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
                                      new Vector4( 1.0f,  1.0f, -1.0f, 1.0f), new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
                                      new Vector4(-1.0f, -1.0f, -1.0f, 1.0f), new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
                                      new Vector4( 1.0f,  1.0f, -1.0f, 1.0f), new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
                                      new Vector4( 1.0f, -1.0f, -1.0f, 1.0f), new Vector4(1.0f, 0.0f, 0.0f, 1.0f),

                                      new Vector4(-1.0f, -1.0f,  1.0f, 1.0f), new Vector4(0.0f, 1.0f, 0.0f, 1.0f), // BACK
                                      new Vector4( 1.0f,  1.0f,  1.0f, 1.0f), new Vector4(0.0f, 1.0f, 0.0f, 1.0f),
                                      new Vector4(-1.0f,  1.0f,  1.0f, 1.0f), new Vector4(0.0f, 1.0f, 0.0f, 1.0f),
                                      new Vector4(-1.0f, -1.0f,  1.0f, 1.0f), new Vector4(0.0f, 1.0f, 0.0f, 1.0f),
                                      new Vector4( 1.0f, -1.0f,  1.0f, 1.0f), new Vector4(0.0f, 1.0f, 0.0f, 1.0f),
                                      new Vector4( 1.0f,  1.0f,  1.0f, 1.0f), new Vector4(0.0f, 1.0f, 0.0f, 1.0f),

                                      new Vector4(-1.0f, 1.0f, -1.0f,  1.0f), new Vector4(0.0f, 0.0f, 1.0f, 1.0f), // Top
                                      new Vector4(-1.0f, 1.0f,  1.0f,  1.0f), new Vector4(0.0f, 0.0f, 1.0f, 1.0f),
                                      new Vector4( 1.0f, 1.0f,  1.0f,  1.0f), new Vector4(0.0f, 0.0f, 1.0f, 1.0f),
                                      new Vector4(-1.0f, 1.0f, -1.0f,  1.0f), new Vector4(0.0f, 0.0f, 1.0f, 1.0f),
                                      new Vector4( 1.0f, 1.0f,  1.0f,  1.0f), new Vector4(0.0f, 0.0f, 1.0f, 1.0f),
                                      new Vector4( 1.0f, 1.0f, -1.0f,  1.0f), new Vector4(0.0f, 0.0f, 1.0f, 1.0f),

                                      new Vector4(-1.0f,-1.0f, -1.0f,  1.0f), new Vector4(1.0f, 1.0f, 0.0f, 1.0f), // Bottom
                                      new Vector4( 1.0f,-1.0f,  1.0f,  1.0f), new Vector4(1.0f, 1.0f, 0.0f, 1.0f),
                                      new Vector4(-1.0f,-1.0f,  1.0f,  1.0f), new Vector4(1.0f, 1.0f, 0.0f, 1.0f),
                                      new Vector4(-1.0f,-1.0f, -1.0f,  1.0f), new Vector4(1.0f, 1.0f, 0.0f, 1.0f),
                                      new Vector4( 1.0f,-1.0f, -1.0f,  1.0f), new Vector4(1.0f, 1.0f, 0.0f, 1.0f),
                                      new Vector4( 1.0f,-1.0f,  1.0f,  1.0f), new Vector4(1.0f, 1.0f, 0.0f, 1.0f),

                                      new Vector4(-1.0f, -1.0f, -1.0f, 1.0f), new Vector4(1.0f, 0.0f, 1.0f, 1.0f), // Left
                                      new Vector4(-1.0f, -1.0f,  1.0f, 1.0f), new Vector4(1.0f, 0.0f, 1.0f, 1.0f),
                                      new Vector4(-1.0f,  1.0f,  1.0f, 1.0f), new Vector4(1.0f, 0.0f, 1.0f, 1.0f),
                                      new Vector4(-1.0f, -1.0f, -1.0f, 1.0f), new Vector4(1.0f, 0.0f, 1.0f, 1.0f),
                                      new Vector4(-1.0f,  1.0f,  1.0f, 1.0f), new Vector4(1.0f, 0.0f, 1.0f, 1.0f),
                                      new Vector4(-1.0f,  1.0f, -1.0f, 1.0f), new Vector4(1.0f, 0.0f, 1.0f, 1.0f),

                                      new Vector4( 1.0f, -1.0f, -1.0f, 1.0f), new Vector4(0.0f, 1.0f, 1.0f, 1.0f), // Right
                                      new Vector4( 1.0f,  1.0f,  1.0f, 1.0f), new Vector4(0.0f, 1.0f, 1.0f, 1.0f),
                                      new Vector4( 1.0f, -1.0f,  1.0f, 1.0f), new Vector4(0.0f, 1.0f, 1.0f, 1.0f),
                                      new Vector4( 1.0f, -1.0f, -1.0f, 1.0f), new Vector4(0.0f, 1.0f, 1.0f, 1.0f),
                                      new Vector4( 1.0f,  1.0f, -1.0f, 1.0f), new Vector4(0.0f, 1.0f, 1.0f, 1.0f),
                                      new Vector4( 1.0f,  1.0f,  1.0f, 1.0f), new Vector4(0.0f, 1.0f, 1.0f, 1.0f),
                            });*/
        }
        public List<Component> components = new List<Component>();
        public Transform transform = new Transform();
        public Entity()
        {
            components.Add(transform);
            Scene.Current.entities.Add(this);
        }
        public T AddComponent<T>() where T : Component, new()
        {
            Component component = new T() { };
            component.entity = this;
            components.Add(component);
            return (T)component;
        }
        public void Update()
        {
            foreach(var component in components)
            {
                component.Update();
            }
        }
    }
}
