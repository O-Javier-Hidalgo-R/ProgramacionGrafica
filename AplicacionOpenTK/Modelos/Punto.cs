using System.Runtime.Serialization;

namespace AplicacionOpenTK.Modelos
{
    [DataContract]
    public class Punto<T>
    {
        [DataMember]
        public T x;
        [DataMember]
        public T y;
        [DataMember]
        public T z;

        public Punto()
        {

        }

        public Punto(T x, T y, T z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Punto(Punto<T> punto)
        {
            this.X = punto.X;
            this.Y = punto.Y;
            this.Z = punto.Z;
        }

        public T X { get => x; set => x = value; }
        public T Y { get => y; set => y = value; }
        public T Z { get => z; set => z = value; }

        public override string ToString()
        {
            return "(" + x.ToString() + ", " + y.ToString() + ", " + z.ToString() + ")";
        }
    }
}
