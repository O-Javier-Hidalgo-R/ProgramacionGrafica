namespace AplicacionOpenTK.Interfaces
{
    internal interface ITransformable
    {
        //Transformacion de traslacion
        void trasladar(float enX, float enY, float enZ);

        //Transformacion de rotacion
        void rotar(float angX, float angY, float angZ);

        //Transformacion de escalacion
        void escalar(float enX, float enY, float enZ);
    }
}
