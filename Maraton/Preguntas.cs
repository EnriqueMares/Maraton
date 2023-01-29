using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Maraton
{
    public class Preguntas
    {
        //Atributos
        private List<Pregunta> lista = new List<Pregunta>();



        //Propiedades
        public List<Pregunta> Lista
        {
            get { return lista; }
            set { lista = value; }
        }


        //Metodos
        public void Guardar(string ruta, List<Pregunta> lista)
        {
            List<Pregunta> listaDePreguntas = lista;
            try
            {
                //Guardar
                FileStream fs = new FileStream(ruta, FileMode.Create);
                //XmlTextWriter escritor = new XmlTextWriter(ruta, Encoding.UTF8);
                //escritor.Formatting = Formatting.Indented;
                XmlSerializer serializador = new XmlSerializer(typeof(List<Pregunta>));
                serializador.Serialize(fs, lista);
                fs.Close();
            }
            catch (Exception e)
            {

            }
        }
        public static List<Pregunta> Cargar(string ruta)
        {
            List<Pregunta> listaDePreguntas;
            XmlTextReader lector = new XmlTextReader(ruta);
            XmlSerializer serializador = new XmlSerializer(typeof(List<Pregunta>));
            listaDePreguntas = (List<Pregunta>)serializador.Deserialize(lector);
            lector.Close();

            //Para asegurar que nunca falle, por si no existe la lista
            if (listaDePreguntas == null)
            {
                // listaDeCanciones = new Canciones();
            }
            return listaDePreguntas;
        }

    }
}
