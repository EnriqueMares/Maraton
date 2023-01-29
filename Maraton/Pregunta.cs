using System;
using System.Collections.Generic;
using System.Text;

namespace Maraton
{
    public class Pregunta
    {
        //Atributos
        private string preguntaTexto;
        private string opcion1;
        private string opcion2;
        private string opcion3;
        private string respuesta;

        //Propiedades
        public string PreguntaTexto
        {
            get { return preguntaTexto; }
            set { preguntaTexto = value; }
        }

        public string Opcion1
        {
            get { return opcion1; }
            set { opcion1 = value; }
        }

        public string Opcion2
        {
            get { return opcion2; }
            set { opcion2 = value; }
        }

        public string Opcion3
        {
            get { return opcion3; }
            set { opcion3 = value; }
        }

        public string Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; }
        }
    }
}

