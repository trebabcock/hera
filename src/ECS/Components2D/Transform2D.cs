using Hera.MathH;

namespace Hera.ECS.Components2D
{
    public class Transform2D : Component
    {
        public Vector2 Position { get; set; }
        public Vector2 Scale { get; set; }
        public float Rotation { get; set; }

        public Transform2D(Vector2 position)
        {
            this.Position = position;
            this.Scale = Vector2.One;
            this.Rotation = 0f;

            base.Tag = "Transform2D";
        }

        public void SetPosition(Vector2 newPosition)
        {
            this.Position = newPosition;
        }

        public void SetScale(Vector2 newScale)
        {
            this.Scale = newScale;
        }

        public void SetRotation(float newRotation)
        {
            this.Rotation = newRotation;
        }
    }
}