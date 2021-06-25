using OpenTK.Graphics.OpenGL;

namespace Hera.ECS.Components2D
{
    public class Renderer2D : Component
    {
        float[] vertices = {
            -0.5f, -0.5f, 0.0f, //Bottom-left vertex
            0.5f, -0.5f, 0.0f, //Bottom-right vertex
            0.0f,  0.5f, 0.0f  //Top vertex
        };
        int VertexBufferObject;
        public Renderer2D()
        {
            base.Tag = "Renderer2D";
        }

        public void OnLoad()
        {
            this.VertexBufferObject = GL.GenBuffer();
        }
    }
}