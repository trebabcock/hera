using System;

namespace Hera.ECS
{
    public class Component
    {
        public string Tag { get; set; }
        public bool IsActive { get; set; }
        public int EntityID { get; set; }

        public Component() { }

        public Component(string tag)
        {
            this.Tag = tag;
            this.IsActive = true;
        }
    }
}