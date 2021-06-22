using System;
using System.Linq;
using System.Collections.Generic;

namespace Hera.ECS
{
    public class Entity
    {
        public string Name { get; set; }
        public string Tag { get; set; }
        public int ID { get; set; }

        public List<Component> Components { get; set; }

        public Entity(string name, string tag, int id)
        {
            this.Name = name;
            this.Tag = Tag;
            this.ID = id;
            this.Components = new List<Component>();
        }

        public void AddComponent(Component component)
        {
            this.Components.Add(component);
        }

        public void RemoveComponent(Component component)
        {
            this.Components.Remove(component);
        }

        public T GetComponent<T>() where T : Component
        {
            var component = this.Components.FirstOrDefault(component => component.GetType() == typeof(T));

            if (component != null)
            {
                return (T)component;
            }
            return null;
        }

        public List<Component> GetComponents()
        {
            return this.Components;
        }
    }
}