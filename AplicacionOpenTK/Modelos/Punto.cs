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

        /*
        public static Punto operator *(Matrix4 m, Punto p)
        {
            return new Punto(
                m.M11*p.X + m.M12*p.Y + m.M13*p.Z + m.M14,
                m.M21*p.X + m.M22*p.Y + m.M23*p.Z + m.M24,
                m.M31*p.X + m.M32*p.Y + m.M33*p.Z + m.M34
                );
            
            Vector4 vectorP = new Vector4(p.X, p.Y, p.Z, 1);
            Vector4 a = m * vectorP;
            return new Punto(a.X, a.Y, a.Z);
        }
        */

        public void trasladar(float enX, float enY, float enZ)
        {
            Matrix4 matrixTraslacion = Matrix4.CreateTranslation(enX, enY, enZ);
            Vector4 PuntoTrasladado = new Vector4(X, Y, Z, 1);
            PuntoTrasladado = PuntoTrasladado * matrixTraslacion;

            X = PuntoTrasladado.X; 
            Y = PuntoTrasladado.Y; 
            Z = PuntoTrasladado.Z;
        }

        public void rotar(float angX, float angY, float angZ)
        {
            angX = MathHelper.DegreesToRadians(angX);
            angY = MathHelper.DegreesToRadians(angY);
            angZ = MathHelper.DegreesToRadians(angZ);

            Matrix4 matrixRotacion = Matrix4.CreateRotationX(angX) * Matrix4.CreateRotationY(angY) * Matrix4.CreateRotationZ(angZ);

            Vector4 PuntoRotado = new Vector4(X, Y, Z, 1);
            PuntoRotado = PuntoRotado * matrixRotacion;

            X = PuntoRotado.X;
            Y = PuntoRotado.Y;
            Z = PuntoRotado.Z;
        }

        public void escalar(float enX, float enY, float enZ)
        {
            Matrix4 matrixEscalacion = Matrix4.CreateScale(enX, enY, enZ);
            Vector4 PuntoEscalado = new Vector4(X, Y, Z, 1);
            PuntoEscalado = PuntoEscalado * matrixEscalacion;

            X = PuntoEscalado.X;
            Y = PuntoEscalado.Y;
            Z = PuntoEscalado.Z;
        }
        public static Punto operator +(Punto a, Punto b)
        {
            return new Punto(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

    }
}
