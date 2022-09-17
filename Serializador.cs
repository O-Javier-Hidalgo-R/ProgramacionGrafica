using Newtonsoft.Json;
using Proyecto1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTriangle
{
    //Nuevo: clase que se usa para serializar y deserializar un objeto (triangulo) desde un .json
    public class Serializador
    {
        //Atributo tipo string que lleva el directorio del archivo .json
        private string _path;

        //Construnctor por que permite nombrar el .json
        public Serializador(string name)
        {
            _path = name + ".json";
        }

        //Metodo para serializar un objeto entrante tipo triangulo a archivo .json
        public void Serializar(Triangulo triangulo)
        {
            //genera el string json
            string json = JsonConvert.SerializeObject(triangulo, Formatting.Indented);

            //guarda el string json como archivo .json
            File.WriteAllText(_path, json);
        }

        //Funcion que retorna un triangulo con los valores obtenidos de un .json
        public Triangulo Deserealizar()
        {
            string json;

            //se obtiene en un string los valores guardados en el .json
            using (var reader = new StreamReader(_path))
            {
                json = reader.ReadToEnd();
            }

            //agrega los valores del string json a un triangulo
            Triangulo triangulo = JsonConvert.DeserializeObject<Triangulo>(json);

            //retorna ese triangulo
            return triangulo;
        }
    }
}
