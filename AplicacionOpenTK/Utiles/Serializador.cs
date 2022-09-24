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
    public class Serializador<T>
    {
        //Atributo tipo string que lleva el directorio del archivo .json
        private string _path;

        //Construnctor por que permite nombrar el .json
        public Serializador(string name)
        {
            _path = name + ".json";
        }

        //Metodo para serializar un objeto entrante tipo triangulo a archivo .json
        public void Serializar(T objecto)
        {
            //genera el string json
            string json = JsonConvert.SerializeObject(objecto, Formatting.Indented);

            //guarda el string json como archivo .json
            File.WriteAllText(_path, json);
        }

        //Funcion que retorna un triangulo con los valores obtenidos de un .json
        public T Deserealizar()
        {
            string json;

            //se obtiene en un string los valores guardados en el .json
            using (var reader = new StreamReader(_path))
            {
                json = reader.ReadToEnd();
            }

            //agrega los valores del string json a un objeto
            T objeto = JsonConvert.DeserializeObject<T>(json);
            //dynamic obj = JsonConvert.DeserializeObject<dynamic>(json);
            //T objeto = JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(obj.partes));

            //retorna ese triangulo
            return objeto;
        }
    }
}
