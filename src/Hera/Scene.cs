using Hera.ECS;
using System.Collections.Generic;

namespace Hera
{
    public class Scene
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public List<Entity> Entities { get; set; }

        public Scene(string name, int id)
        {
            this.Name = name;
            this.ID = id;
            this.Entities = new List<Entity>();
        }
    }
}