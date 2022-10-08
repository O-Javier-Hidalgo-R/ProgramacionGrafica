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

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public float Z { get => z; set => z = value; }

        public Punto suma(Punto a, Punto b)
        {
            float p = a.X + b.X;
            float q = a.Y + b.Y;
            float r = a.Z + b.Z;

            return new Punto(p, q, r);
        }

        public override string ToString()
        {
            return "(" + x.ToString() + ", " + y.ToString() + ", " + z.ToString() + ")";
        }

    }
}
