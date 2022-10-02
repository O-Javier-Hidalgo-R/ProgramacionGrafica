using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionOpenTK.Utiles
{
    //SE PUEDE HACER UNA INTERFAZ O CLASE ABSTRACTA ¿CUAL ES MEJOR?, ¿POR QUE?
    public class Serializador<T>
    {
        //PUEDE EXISTIR UNA CLASE SIN ATRIBUTOS ???
        //QUIERO QUE GUARDE LOS OBJETOS EN UNA CARPETA HOMONIMA

        //Metodo para serializar un objeto entrante tipo triangulo a archivo .json
        public void Serializar(string dir, T objecto)
        {
            //genera el string json (formato identado)
            string json = JsonConvert.SerializeObject(objecto, Formatting.Indented);

            //guarda el string json como archivo .json
            File.WriteAllText(dir, json);
        }

        //Funcion que retorna un triangulo con los valores obtenidos de un .json
        public T Deserealizar(string dir)
        {
            string json;

            //se obtiene en un string los valores guardados en el .json
            using (var reader = new StreamReader(dir))
            {
                json = reader.ReadToEnd();
            }

            //agrega los valores del string json a un objeto
            T objeto = JsonConvert.DeserializeObject<T>(json);

            //retorna el objeto
            return objeto;
        }
    }
}
