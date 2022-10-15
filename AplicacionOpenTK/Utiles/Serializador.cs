using AplicacionOpenTK.Modelos;
using Newtonsoft.Json;
using OpenTK.Graphics;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace AplicacionOpenTK.Utiles
{
    //SE PUEDE HACER UNA INTERFAZ O CLASE ABSTRACTA ¿CUAL ES MEJOR?, ¿POR QUE?
    public class Serializador<T>
    {
        //PUEDE EXISTIR UNA CLASE SIN ATRIBUTOS ???
        //QUIERO QUE GUARDE LOS OBJETOS EN UNA CARPETA HOMONIMA

        public void Serializar(string dir, T serializable)
        {
            //Genera el string serializado json (formato identado).
            string contenido = JsonConvert.SerializeObject(serializable, Formatting.Indented);

            //Guarda el contenido serializado en la direccion.
            File.WriteAllText(dir, contenido);
        }

        //Funcion que retorna un serializable json cargandolo desde una direccion.
        public T CargarJson(string dir)
        {
            if (!File.Exists(dir))
            {
                throw new FileNotFoundException("No existe la direccion: \"" + dir + "\"");
            }

            string serializado;

            //Funcion del sistema que lee una ruta especificada.
            using (var reader = new StreamReader(dir))
            {
                serializado = reader.ReadToEnd();
            }

            //Inicializa los valores del serializable desde un json serializado.
            T serializable = JsonConvert.DeserializeObject<T>(serializado);

            //Retorna un serializable.
            return serializable;
        }

        //Funcion que retorna un serializable obj cargandolo desde una direccion y relacionandolo con un punto centro.
        public static Objeto CargarObj(string dir, Punto centro)
        {
            if (!File.Exists(dir))
            {
                throw new FileNotFoundException("No existe la direccion: \"" + dir + "\"");
            }

            List<Punto> puntos = new List<Punto>();
            
            //HashSet<Punto<float>> textureVertices = new HashSet<Punto<float>>();
            //HashSet<Punto<float>> normals = new HashSet<Punto<float>>();
            


            Dictionary<string, Parte> caras = new Dictionary<string, Parte>();
            
            //List<uint> textureIndices = new List<uint>();
            //List<uint> normalIndices = new List<uint>();
            


            using (StreamReader streamReader = new StreamReader(dir))
            {
                int Contador = 0;
                while (!streamReader.EndOfStream)
                {
                    List<string> words = new List<string>(streamReader.ReadLine().ToLower().Split(' '));
                    words.RemoveAll(s => s == string.Empty);

                    if (words.Count == 0)
                        continue;

                    string type = words[0];
                    words.RemoveAt(0);

                    switch (type)
                    {
                        // vertex
                        case "v":
                            puntos.Add(new Punto(float.Parse(words[0], CultureInfo.InvariantCulture),
                                float.Parse(words[1], CultureInfo.InvariantCulture),
                                float.Parse(words[2], CultureInfo.InvariantCulture)));
                            break;

                        case "vt":
                            //textureVertices.Add(new Punto<float>(float.Parse(words[0], CultureInfo.InvariantCulture),
                                //float.Parse(words[1], CultureInfo.InvariantCulture),
                                //words.Count < 3 ? 0 : float.Parse(words[2], CultureInfo.InvariantCulture)));
                            break;

                        case "vn":
                            //normals.Add(
                                //new Punto<float>(float.Parse(words[0], CultureInfo.InvariantCulture),
                                    //float.Parse(words[1], CultureInfo.InvariantCulture),
                                    //float.Parse(words[2], CultureInfo.InvariantCulture)));
                            break;

                        // face
                        case "f":
                            Dictionary<string, Punto> Vertices = new Dictionary<string, Punto>();
                            int key = 0;
                            foreach (string w in words)
                            {
                                if (w.Length == 0)
                                    continue;

                                string[] comps = w.Split('/');

                                // subtract 1: indices start from 1, not 0
                                int index = int.Parse(comps[0]) - 1;
                                Vertices.Add(key.ToString(),new Punto(puntos[index].X, puntos[index].Y, puntos[index].Z));

                                //if (comps.Length > 1 && comps[1].Length != 0)
                                    //textureIndices.Add(uint.Parse(comps[1]) - 1);

                                //if (comps.Length > 2)
                                    //normalIndices.Add(uint.Parse(comps[2]) - 1);

                                key++;
                            }

                            caras.Add(Contador.ToString(),new Parte(Vertices, Color4.Red, centro));

                            break;
                    }

                    Contador++;
                }

                return new Objeto(caras, centro);
            }
        }
    }
}
