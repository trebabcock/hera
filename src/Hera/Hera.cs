using System;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using Hera.Graphics;

namespace Hera
{
    public class Game
    {
        public List<Scene> Scenes { get; set; }
        public Scene defaultScene;
        private Scene currentScene;
        //private HeraWindow window;
        private int width;
        private int height;
        private string title;
        private bool running;

        public int Width => this.width;
        public int Height => this.Height;
        public string Title => this.title;
        public bool Running => this.running;

        public Game(int width, int height, string title)
        {
            this.width = width;
            this.height = height;
            this.title = title;
            this.running = true;
        }

        public void Run(double fps)
        {
            if (defaultScene == null)
            {
                throw new System.Exception("No default scene set!");
            }
            // using (this.window = new HeraWindow(this.width, this.height, this.title))
            // {
            //     while (!this.running)
            //     {
            //         Console.WriteLine("NOT RUNNING");
            //     }
            //     Console.WriteLine("RUNNING");
            //     this.window.Run(fps);
            // }
        }

        public void AddScene(Scene scene)
        {
            this.Scenes.Add(scene);
        }

        public void SetDefaultScene(Scene scene)
        {
            this.defaultScene = scene;
            this.currentScene = scene;
        }

        public void LoadScene(Scene scene)
        {
            this.currentScene = scene;
        }

        public void Pause()
        {
            this.running = false;
        }

        public void Resume()
        {
            this.running = true;
        }
    }

    // public class HeraWindow : OpenTK.GameWindow
    // {
    //     Shader shader;
    //     float[] vertices = {
    //         -0.5f, -0.5f, 0.0f, //Bottom-left vertex
    //         0.5f, -0.5f, 0.0f, //Bottom-right vertex
    //         0.0f,  0.5f, 0.0f  //Top vertex
    //     };
    //     int VertexBufferObject;
    //     public HeraWindow(int width, int height, string title) : base(width, height, OpenTK.Graphics.GraphicsMode.Default, title)
    //     {

    //     }

    //     protected override void OnUpdateFrame(FrameEventArgs e)
    //     {
    //         base.OnUpdateFrame(e);
    //     }

    //     protected override void OnLoad(EventArgs e)
    //     {
    //         GL.Clear(ClearBufferMask.ColorBufferBit);
    //         base.OnLoad(e);
    //         VertexBufferObject = GL.GenBuffer();
    //         shader = new Shader("Graphics/Shaders/triangle.vert", "Graphics/Shaders/triangle.frag");
    //     }

    //     protected override void OnResize(EventArgs e)
    //     {
    //         GL.Viewport(0, 0, Width, Height);
    //         base.OnResize(e);
    //     }

    //     protected override void OnUnload(EventArgs e)
    //     {
    //         GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
    //         GL.DeleteBuffer(VertexBufferObject);
    //         base.OnUnload(e);
    //         shader.Dispose();
    //     }
    // }
}