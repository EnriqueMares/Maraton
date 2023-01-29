using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Maraton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variables
        List<Pregunta> preguntasCulturaGeneral;
        List<Pregunta> preguntasHistoria;
        List<Pregunta> preguntasDeportes;
        List<Pregunta> preguntasEspectaculos;
        List<Pregunta> preguntasCapciosas;

        Random numeroCategoria = new Random();
        Random numeroPregunta = new Random();
        int categoria;
        int pregunta;
        int vistaCategoria = 0;
        string respuestaCorrecta;
        int posicionUsuario = 0;
        int posicionCompu = 0;
        bool empate = false;
        bool verCorrecta = true;

        //Metodos
        public void Desaparacer()
        {
            cboCategorias.Visible = false;
          //  txtColorCategoria.Visible = false;
            rctPregunta.Visible = false;
            pctOpcion1.Visible = false;
            pctOpcion2.Visible = false;
            pctOpcion3.Visible = false; 
            lblOpcion1.Visible = false;
            lblOpcion2.Visible = false;
            lblOpcion3.Visible = false;
            pctCorrecto1.Visible = false;
            pctCorrecta2.Visible = false;
            pctCorrecta3.Visible = false;
        }
        public void Aparecer()
        {
            cboCategorias.Visible =true;
            txtColorCategoria.Visible = true;
            rctPregunta.Visible = true;
            pctOpcion1.Visible = true;
            pctOpcion2.Visible = true;
            pctOpcion3.Visible = true;
            lblOpcion1.Visible = true;
            lblOpcion2.Visible = true;
            lblOpcion3.Visible = true;            
        }
        public void EscogerColor(int numero)
        {
            switch (numero)
            {
                case 1://1 Cultura General
                    txtColorCategoria.BackColor = Color.Green;//Verde
                    break;
                case 2://2 Historia Universal
                    txtColorCategoria.BackColor = Color.Red;//Rojo
                    break;
                case 3://3 Juegos y Deportes
                    txtColorCategoria.BackColor = Color.Yellow;//Amarillo
                    break;
                case 4://4 Espectaculos
                    txtColorCategoria.BackColor = Color.Blue;//Azul
                    break;
                case 5://5 De Pensarse
                    txtColorCategoria.BackColor = Color.Orange;//Naranja
                    break;
                default:
                    break;
            }
        }
        public void EscogerRangoPreguntas(int numero)
        {
            switch (numero)
            {
                case 1://1 Cultura General                    
                    pregunta=numeroPregunta.Next(1, preguntasCulturaGeneral.Count);
                    rctPregunta.Text = preguntasCulturaGeneral[pregunta - 1].PreguntaTexto;
                    lblOpcion1.Text = preguntasCulturaGeneral[pregunta - 1].Opcion1;
                    lblOpcion2.Text = preguntasCulturaGeneral[pregunta - 1].Opcion2;
                    lblOpcion3.Text = preguntasCulturaGeneral[pregunta - 1].Opcion3;
                    respuestaCorrecta = preguntasCulturaGeneral[pregunta - 1].Respuesta;
                    break;
                case 2://2 Historia Universal
                    numeroPregunta = new Random();
                    pregunta=numeroPregunta.Next(1, preguntasHistoria.Count);
                    rctPregunta.Text = preguntasHistoria[pregunta - 1].PreguntaTexto;
                    lblOpcion1.Text = preguntasHistoria[pregunta - 1].Opcion1;
                    lblOpcion2.Text = preguntasHistoria[pregunta - 1].Opcion2;
                    lblOpcion3.Text = preguntasHistoria[pregunta - 1].Opcion3;
                    respuestaCorrecta = preguntasHistoria[pregunta - 1].Respuesta;
                    break;
                case 3://3 Juegos y Deportes
                    numeroPregunta = new Random();
                    pregunta=numeroPregunta.Next(1, preguntasDeportes.Count);
                    rctPregunta.Text = preguntasDeportes[pregunta - 1].PreguntaTexto;
                    lblOpcion1.Text = preguntasDeportes[pregunta - 1].Opcion1;
                    lblOpcion2.Text = preguntasDeportes[pregunta - 1].Opcion2;
                    lblOpcion3.Text = preguntasDeportes[pregunta - 1].Opcion3;
                    respuestaCorrecta = preguntasDeportes[pregunta - 1].Respuesta;
                    break;
                case 4://4 Espectaculos
                    numeroPregunta = new Random();
                    pregunta=numeroPregunta.Next(1, preguntasEspectaculos.Count);
                    rctPregunta.Text = preguntasEspectaculos[pregunta - 1].PreguntaTexto;
                    lblOpcion1.Text = preguntasEspectaculos[pregunta - 1].Opcion1;
                    lblOpcion2.Text = preguntasEspectaculos[pregunta - 1].Opcion2;
                    lblOpcion3.Text = preguntasEspectaculos[pregunta - 1].Opcion3;
                    respuestaCorrecta = preguntasEspectaculos[pregunta - 1].Respuesta;
                    break;
                case 5://5 De Pensarse
                    numeroPregunta = new Random();
                    pregunta=numeroPregunta.Next(1, preguntasCapciosas.Count);
                    rctPregunta.Text = preguntasCapciosas[pregunta - 1].PreguntaTexto;
                    lblOpcion1.Text = preguntasCapciosas[pregunta - 1].Opcion1;
                    lblOpcion2.Text = preguntasCapciosas[pregunta - 1].Opcion2;
                    lblOpcion3.Text = preguntasCapciosas[pregunta - 1].Opcion3;
                    respuestaCorrecta = preguntasCapciosas[pregunta - 1].Respuesta;
                    break;
                default:
                    break;
            }
        }
        private void AvanzarUsuario()
        {
            switch (posicionUsuario)
            {
                case 1:
                    pctInicio.Visible = false;
                    pctCasilla1.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 2:                    
                    pctCasilla2.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 3:                    
                    pctCasilla3.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 4:                    
                    pctCasilla4.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 5:                    
                    pctCasilla5.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 6:                    
                    pctCasilla6.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 7:                    
                    pctCasilla7.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 8:                    
                    pctCasilla8.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 9:                    
                    pctCasilla9.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 10:                    
                    pctCasilla10.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 11:                    
                    pctCasilla11.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 12:                    
                    pctCasilla12.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 13:                    
                    pctCasilla13.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 14:                    
                    pctCasilla14.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 15:                    
                    pctCasilla15.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 16:                    
                    pctCasilla16.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 17:                    
                    pctCasilla17.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 18:                    
                    pctCasilla18.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 19:                    
                    pctCasilla19.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 20:                    
                    pctCasilla20.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 21:                    
                    pctCasilla21.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 22:                    
                    pctCasilla22.Image = Image.FromFile(@"..\..\Imagenes\Disquin.png");
                    break;
                case 23:                    
                    pctMeta.Image = Image.FromFile(@"..\..\Imagenes\Meta Disquin.png");                                       
                    break;
                default:
                    break;
            }
        }
        private void AvanzarCompu()
        {
            switch (posicionCompu)
            {
                case 1:
                    pctInicio.Visible = false;
                    pctCasilla1.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 2:                    
                    pctCasilla2.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 3:                    
                    pctCasilla3.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 4:                    
                    pctCasilla4.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 5:                    
                    pctCasilla5.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 6:                    
                    pctCasilla6.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 7:                    
                    pctCasilla7.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 8:                    
                    pctCasilla8.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 9:                    
                    pctCasilla9.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 10:                    
                    pctCasilla10.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 11:                    
                    pctCasilla11.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 12:                    
                    pctCasilla12.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 13:                    
                    pctCasilla13.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 14:                    
                    pctCasilla14.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 15:                    
                    pctCasilla15.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 16:                    
                    pctCasilla16.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 17:                    
                    pctCasilla17.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 18:                    
                    pctCasilla18.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 19:                    
                    pctCasilla19.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 20:                    
                    pctCasilla20.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 21:                    
                    pctCasilla21.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 22:                    
                    pctCasilla22.Image = Image.FromFile(@"..\..\Imagenes\Ranchero.png");
                    break;
                case 23:                    
                    pctMeta.Image = Image.FromFile(@"..\..\Imagenes\Meta Ranchero.png");                                      
                    break;
                default:
                    break;
            }
        }
        private void TodosCasillasVacias()
        {
            pctCasilla1.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla2.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla3.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla4.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla5.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla6.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla7.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla8.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla9.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla10.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla11.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla12.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla13.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla14.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla15.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla16.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla17.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla18.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla19.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla20.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla21.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
            pctCasilla22.Image = Image.FromFile(@"..\..\Imagenes\Casilla.jpg");
        }
        private void Empatar()
        {
            TodosCasillasVacias();
            switch (posicionUsuario)
            {
                case 1:
                    pctCasilla1.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 2:
                    pctCasilla2.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 3:
                    pctCasilla3.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 4:
                    pctCasilla4.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 5:
                    pctCasilla5.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 6:
                    pctCasilla6.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 7:
                    pctCasilla7.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 8:
                    pctCasilla8.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 9:
                    pctCasilla9.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 10:
                    pctCasilla10.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 11:
                    pctCasilla11.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 12:
                    pctCasilla12.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 13:
                    pctCasilla13.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 14:
                    pctCasilla14.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 15:
                    pctCasilla15.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 16:
                    pctCasilla16.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 17:
                    pctCasilla17.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 18:
                    pctCasilla18.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 19:
                    pctCasilla19.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 20:
                    pctCasilla20.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 21:
                    pctCasilla21.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                case 22:
                    pctCasilla22.Image = Image.FromFile(@"..\..\Imagenes\Empate.png");
                    break;
                default:
                    break;
            }
        }
        private void Desempatar()
        {
            TodosCasillasVacias();
            AvanzarUsuario();
            AvanzarCompu();
        }
        private void CasosEspeciales()
        {
            //Casos Especiales
            if (posicionCompu == 0)
            {
                pctInicio.Visible = true;
                pctInicio.Image = Image.FromFile(@"..\..\Imagenes\Salida Ranchero.png");
            }

            if (posicionUsuario == 0)
            {
                pctInicio.Visible = true;
                pctInicio.Image = Image.FromFile(@"..\..\Imagenes\Salida Disquin.png");
            }

            //Empate
            if (posicionUsuario == posicionCompu)
            {
                Empatar();
                empate = true;
            }

            //Desempate
            if (posicionUsuario + 1 == posicionCompu && empate == true)
            {
                Desempatar();
                empate = false;
            }
            if (posicionCompu + 1 == posicionUsuario && empate == true)
            {
                Desempatar();
                empate = false;
            }

            //Ganar
            if (posicionUsuario == 23)
            {                
                pctLanzarPregunta.Visible = false;
                tmCorrecta.Stop();
                MessageBox.Show("FELICIDADES GANASTE");
            }
            else
            {
                pctLanzarPregunta.Visible = true;
            }

            if (posicionCompu==23)
            {
                pctLanzarPregunta.Visible = false;
                tmCorrecta.Stop();
                MessageBox.Show("Lo Sentimos Perdiste");
            }
            else
            {
                pctLanzarPregunta.Visible = true;
            }
        }
        private void InhabilitarOpciones()
        {
            pctOpcion1.Enabled = false;
            pctOpcion2.Enabled = false;
            pctOpcion3.Enabled = false;
        }
        private void HabilitarOpciones()
        {
            pctOpcion1.Enabled = true;
            pctOpcion2.Enabled = true;
            pctOpcion3.Enabled = true;
        }

        private void pctLanzarPregunta_Click(object sender, EventArgs e)
        {
            /*AxShockwaveFlashObjects.AxShockwaveFlash pelicula=new AxShockwaveFlashObjects.AxShockwaveFlash();
            pelicula.Movie=direccionAmimacion;
            pelicula.Play();*/
            txtColorCategoria.Visible = true;
            tmCategorias.Start();            
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {
            //Cargar todas las preguntas            
            preguntasCulturaGeneral=Preguntas.Cargar(@"..\..\Preguntas\Cultura General.xml");//Cultura General
            preguntasHistoria = Preguntas.Cargar(@"..\..\Preguntas\Historia Universal.xml");//Historia
            preguntasDeportes = Preguntas.Cargar(@"..\..\Preguntas\Deportes.xml");//Juegos y Deportes
            preguntasEspectaculos = Preguntas.Cargar(@"..\..\Preguntas\Espectaculos.xml");//Espectaculos
            preguntasCapciosas = Preguntas.Cargar(@"..\..\Preguntas\De pensarse.xml");//De Pensarse

            //Desaparecer preguntas y opciones
            Desaparacer();
        }

        private void pctOpcion1_MouseMove(object sender, MouseEventArgs e)
        {
            pctOpcion1.Image = Image.FromFile(@"..\..\Imagenes\Respuesta.png");
        }

        private void pctOpcion2_MouseMove(object sender, MouseEventArgs e)
        {
            pctOpcion2.Image = Image.FromFile(@"..\..\Imagenes\Respuesta.png");
        }

        private void pctOpcion3_MouseMove(object sender, MouseEventArgs e)
        {
            pctOpcion3.Image = Image.FromFile(@"..\..\Imagenes\Respuesta.png");
        }

        private void pctOpcion1_MouseLeave(object sender, EventArgs e)
        {
            pctOpcion1.Image = Image.FromFile(@"..\..\Imagenes\Opcion.png");
        }

        private void pctOpcion2_MouseLeave(object sender, EventArgs e)
        {
            pctOpcion2.Image = Image.FromFile(@"..\..\Imagenes\Opcion.png");
        }
        private void pctOpcion3_MouseLeave(object sender, EventArgs e)
        {
            pctOpcion3.Image = Image.FromFile(@"..\..\Imagenes\Opcion.png");
        }


        private void pctOpcion1_Click(object sender, EventArgs e)
        {            
            if (respuestaCorrecta == lblOpcion1.Text)
            {
                posicionUsuario++;                
            }
            else
            {
                posicionCompu++;          
            }
            txtColorCategoria.Visible = false;            
            tmCorrecta.Start();           
        }
        private void pctOpcion2_Click(object sender, EventArgs e)
        {
            TodosCasillasVacias();
            if (respuestaCorrecta == lblOpcion2.Text)
            {
                posicionUsuario++;               
            }
            else
            {
                posicionCompu++;                
            }
            txtColorCategoria.Visible = false;        
            tmCorrecta.Start();
        }
        private void pctOpcion3_Click(object sender, EventArgs e)
        {
            TodosCasillasVacias();
            if (respuestaCorrecta == lblOpcion3.Text)
            {
                posicionUsuario++;                
            }
            else
            {
                posicionCompu++;                
            }            
            txtColorCategoria.Visible = false;
            tmCorrecta.Start();
        }

        private void tmCategorias_Tick(object sender, EventArgs e)
        {
            //Lanzar Pregunta
            if (vistaCategoria == 4)
            {
             cboCategorias.SelectedIndex = categoria - 1;
             EscogerRangoPreguntas(categoria);
             HabilitarOpciones();

             //Aparecer todo
             Aparecer();
             pctLanzarPregunta.Visible = false;
             vistaCategoria = 1;
             tmCategorias.Stop();
            }
            else
            {
                categoria = numeroCategoria.Next(1, 6);
                EscogerColor(categoria);
                vistaCategoria++;
            }         
        }
        private void tmCorrecta_Tick(object sender, EventArgs e)
        {
            //Inhabilitar
            InhabilitarOpciones();            
            if (verCorrecta == true)
            {
                if (respuestaCorrecta == lblOpcion1.Text)
                {
                    pctCorrecto1.Visible = true;
                }
                if (respuestaCorrecta == lblOpcion2.Text)
                {
                    pctCorrecta2.Visible = true;
                }
                if (respuestaCorrecta == lblOpcion3.Text)
                {
                    pctCorrecta3.Visible = true;
                }
                verCorrecta = false;
            }
            else
            {
                pctCorrecto1.Visible = false;
                pctCorrecta2.Visible = false;
                pctCorrecta3.Visible = false;
                Desaparacer();
                Desempatar();
                //Casos Especiales
                CasosEspeciales();
                verCorrecta = true;
                tmCorrecta.Stop();                
            }
        }
    }
}