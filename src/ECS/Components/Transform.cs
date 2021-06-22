using System;
using Hera.Math;

namespace Hera.ECS.Components
{
    public class Transform : Component
    {
        public Vector3 Position { get; set; }
        public Vector3 Scale { get; set; }
        public float Rotation { get; set; }

        public Transform(Vector3 position)
        {
            this.Position = position;
            this.Scale = Vector3.One;
            this.Rotation = 0f;

            base.Tag = "Transform";
        }

        public void SetPosition(Vector3 newPosition)
        {
            this.Position = newPosition;
        }

        public void SetScale(Vector3 newScale)
        {
            this.Scale = newScale;
        }

        public void SetRotation(float newRotation)
        {
            this.Rotation = newRotation;
        }
    }
}