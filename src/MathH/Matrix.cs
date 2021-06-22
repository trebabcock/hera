namespace Hera.MathH
{
    public struct Matrix2
    {
        private float[,] matrix;

        public int Length => this.matrix.Length;

        public float this[int x, int y]
        {
            get => matrix[x, y];
            set => matrix[x, y] = value;
        }

        public Matrix2(int x, int y)
        {
            this.matrix = new float[x, y];
        }
    }

    public struct Matrix3
    {
        private float[,,] matrix;

        public int Length => this.matrix.Length;

        public float this[int x, int y, int z]
        {
            get => matrix[x, y, z];
            set => matrix[x, y, z] = value;
        }

        public Matrix3(int x, int y, int z)
        {
            this.matrix = new float[x, y, z];
        }

        public Matrix3(float[,,] _matrix)
        {
            this.matrix = _matrix;
        }
    }
}