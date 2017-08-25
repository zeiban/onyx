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
        }
        public List<Component> components = new List<Component>();
        public Transform Transform { get; } = new Transform();
        public Scene Scene { get; private set; }
        public Entity()
        {
            components.Add(Transform);
            Scene.Current.entities.Add(this);
            Scene = Scene.Current;
        }
        public T AddComponent<T>() where T : Component, new()
        {
            Component component = new T() { };
            component.Entity = this;
            components.Add(component);
            return (T)component;
        }
        public T GetComponent<T>() where T : Component
        {
            foreach(Component component in components)
            {
                if (typeof(T) == component.GetType())
                    return (T)component;

            }
            return default(T);
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
