using OpenTK;
using System.Runtime.Serialization;

namespace AplicacionOpenTK.Modelos
{
    [DataContract]
    public class Punto
    {
        [DataMember]
        private float x;
        [DataMember]
        private float y;
        [DataMember]
        private float z;

        public float X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public float Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public float Z
        {
            get
            {
                return z;
            }

            set
            {
                z = value;
            }
        }

        public Punto()
        {

        }

        public Punto(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Punto(Punto punto)
        {
            this.X = punto.X;
            this.Y = punto.Y;
            this.Z = punto.Z;
        }

        public Punto suma(Punto a, Punto b)
        {
            float p = a.X + b.X;
            float q = a.Y + b.Y;
            float r = a.Z + b.Z;

            return new Punto(p, q, r);
        }

        public override string ToString()
        {
            return "(" + X.ToString() + ", " + Y.ToString() + ", " + Z.ToString() + ")";
        }

        public static Punto operator +(Punto a, Punto b) => new Punto(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

        public static Punto operator *(Punto a, Matrix3 b) => new Punto(
            a.X * b.M11 + a.Y * b.M21 + a.Z * b.M31, 
            a.X * b.M12 + a.Y * b.M22 + a.Z * b.M32,
            a.X * b.M13 + a.Y * b.M23 + a.Z * b.M33
        );

        public static Punto operator *(Punto a, Matrix4 b) => new Punto(
            a.X * b.M11 + a.Y * b.M21 + a.Z * b.M31 + b.M41,
            a.X * b.M12 + a.Y * b.M22 + a.Z * b.M32 + b.M42,
            a.X * b.M13 + a.Y * b.M23 + a.Z * b.M33 + b.M43
        );

        public void Set(Punto newVertex)
        {
            X = newVertex.X;
            Y = newVertex.Y;
            Z = newVertex.Z;
        }
    }
}
