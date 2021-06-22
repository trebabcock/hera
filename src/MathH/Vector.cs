namespace Hera.MathH
{
    public struct Vector2
    {
        public double x { get; set; }
        public double y { get; set; }

        public double Magnitude => Distance(Vector2.Zero, this);

        // Returns distance between two vectors
        public static double Distance(Vector2 one, Vector2 two)
        {
            return System.Math.Sqrt(System.Math.Pow(two.x - one.x, 2) + System.Math.Pow(two.y - one.y, 2));
        }

        // Subtract one vector from another
        public static Vector2 operator -(Vector2 one, Vector2 two)
        {
            return new Vector2(one.x - two.x, one.y - two.y);
        }

        // Subtract scalar from vector
        public static Vector2 operator -(Vector2 vector, double scalar)
        {
            return new Vector2(vector.x - scalar, vector.y - scalar);
        }

        // Add two vectors together
        public static Vector2 operator +(Vector2 one, Vector2 two)
        {
            return new Vector2(one.x + two.x, one.y + two.y);
        }

        // Add scalar to vector
        public static Vector2 operator +(Vector2 vector, double scalar)
        {
            return new Vector2(vector.x + scalar, vector.y + scalar);
        }

        // Multiply vector by scalar
        public static Vector2 operator *(Vector2 vector, double scalar)
        {
            return new Vector2(vector.x * scalar, vector.y * scalar);
        }

        public static Vector2 operator *(double scalar, Vector2 vector)
        {
            return new Vector2(vector.x * scalar, vector.y * scalar);
        }

        public static Vector2 operator *(Vector2 one, Vector2 two)
        {
            return new Vector2(one.x * two.x, one.y * two.y);
        }

        public static Vector2 operator /(Vector2 vector, double scalar)
        {
            return new Vector2(vector.x / scalar, vector.y / scalar);
        }

        public static Vector2 LPerpendicular(Vector2 vector)
        {
            return new Vector2(vector.y, -vector.x);
        }

        public static Vector2 RPerpendicular(Vector2 vector)
        {
            return new Vector2(-vector.y, vector.x);
        }

        public static bool operator >(Vector2 one, Vector2 two)
        {
            return one.Magnitude > two.Magnitude;
        }

        public static bool operator <(Vector2 one, Vector2 two)
        {
            return one.Magnitude < two.Magnitude;
        }

        public static bool operator ==(Vector2 one, Vector2 two)
        {
            return (one.x == two.x) && (one.y == two.y);
        }

        public static bool operator !=(Vector2 one, Vector2 two)
        {
            return !(one == two);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        // Returns the dot product of two vectors
        public static double Dot(Vector2 one, Vector2 two)
        {
            return ((one.x * two.x) + (one.y * two.y));
        }

        public override string ToString()
        {
            return string.Format($"({this.x}, {this.y})");
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static Vector2 Zero = new Vector2(0, 0);
        public static Vector2 One = new Vector2(1, 1);
        public static Vector2 Up = new Vector2(0, 1);
        public static Vector2 Down = new Vector2(0, -1);
        public static Vector2 Left = new Vector2(-1, 0);
        public static Vector2 Right = new Vector2(1, 0);
        public static Vector2 UnitX = new Vector2(1, 0);
        public static Vector2 UnitY = new Vector2(0, 1);

        public Vector2 Abs(Vector2 vector)
        {
            return new Vector2(System.Math.Abs(vector.x), System.Math.Abs(vector.y));
        }

        // Constructor
        public Vector2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2(double single)
        {
            this.x = single;
            this.y = single;
        }
    }

    public struct Vector3
    {
        double x { get; set; }
        double y { get; set; }
        double z { get; set; }

        public double Magnitude => Distance(Vector3.Zero, this);

        // Returns distance between two vectors
        public static double Distance(Vector3 one, Vector3 two)
        {
            return System.Math.Sqrt(System.Math.Pow(two.x - one.x, 2) + System.Math.Pow(two.y - one.y, 2) + System.Math.Pow(two.z - one.z, 2));
        }

        // Add two vectors together
        public static Vector3 operator +(Vector3 one, Vector3 two)
        {
            return new Vector3(one.x + two.x, one.y + two.y, one.z + two.z);
        }

        // Add scalar to vector
        public static Vector3 operator +(Vector3 vector, double scalar)
        {
            return new Vector3(vector.x + scalar, vector.y + scalar, vector.z + scalar);
        }

        // Subtract one vector from another
        public static Vector3 operator -(Vector3 one, Vector3 two)
        {
            return new Vector3(one.x - two.x, one.y - two.y, one.z - two.z);
        }

        // Subtract scalar from vector
        public static Vector3 operator -(Vector3 vector, double scalar)
        {
            return new Vector3(vector.x - scalar, vector.y - scalar, vector.z - scalar);
        }

        // Multiply vector by scalar
        public static Vector3 operator *(Vector3 vector, double scalar)
        {
            return new Vector3(vector.x * scalar, vector.y * scalar, vector.z * scalar);
        }

        public static Vector3 operator *(double scalar, Vector3 vector)
        {
            return new Vector3(vector.x * scalar, vector.y * scalar, vector.z * scalar);
        }

        public static Vector3 operator *(Vector3 one, Vector3 two)
        {
            return new Vector3(one.x * two.x, one.y * two.y, one.z * two.z);
        }

        public static bool operator >(Vector3 one, Vector3 two)
        {
            return one.Magnitude > two.Magnitude;
        }

        public static bool operator <(Vector3 one, Vector3 two)
        {
            return one.Magnitude < two.Magnitude;
        }

        public static bool operator ==(Vector3 one, Vector3 two)
        {
            return (one.x == two.x) && (one.y == two.y) && (one.z == two.z);
        }

        public static bool operator !=(Vector3 one, Vector3 two)
        {
            return !(one == two);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        // Returns the dot product of two vectors
        public static double Dot(Vector3 one, Vector3 two)
        {
            return ((one.x * two.x) + (one.y * two.y) + (one.z * two.z));
        }

        public Vector3 Abs(Vector3 vector)
        {
            return new Vector3(System.Math.Abs(vector.x), System.Math.Abs(vector.y), System.Math.Abs(vector.z));
        }

        public override string ToString()
        {
            return string.Format($"({this.x}, {this.y}, {this.z})");
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static Vector3 Zero = new Vector3(0, 0, 0);
        public static Vector3 One = new Vector3(1, 1, 1);
        public static Vector3 UnitX = new Vector3(1, 0, 0);
        public static Vector3 UnitY = new Vector3(0, 1, 0);
        public static Vector3 UnitZ = new Vector3(0, 0, 1);
        public static Vector3 Up = new Vector3(0, 1, 0);
        public static Vector3 Forward = new Vector3(0, 0, 1);

        // Constructor
        public Vector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3(double single)
        {
            this.x = single;
            this.y = single;
            this.z = single;
        }

        public Vector3(Vector2 vector, double z)
        {
            this.x = vector.x;
            this.y = vector.y;
            this.z = z;
        }

        public Vector3(double x, Vector2 vector)
        {
            this.x = x;
            this.y = vector.x;
            this.z = vector.y;
        }
    }
}