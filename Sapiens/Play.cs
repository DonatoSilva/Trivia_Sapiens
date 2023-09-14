using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sapiens
{   
    
    public partial class Play : Form
    {
        //clase para las preguntas, con su atributos
        public class TriviaItem
        {
            public Image Imagen { get; set; }
            public string Question { get; set; }
            public List<string> Options { get; set; }
            public int CorrectOpciton { get; set; }
        }

        private int timeCronometro = 30; //segundo del cronometro
        private string correctOption;
        public Dictionary<int, TriviaItem> Questions { get; set; }
        
        public Play(String name, int numberQuestion, int numberCorect)
        {
            InitializeComponent();
            Questions = new Dictionary<int, TriviaItem>();

            timer1.Enabled = true; // se inicia el cronometro
            numberTrivia.Text = numberQuestion.ToString();
            numberCorrect.Text = numberCorect.ToString();

            // Se crean o agregan las preguntas
            SetQuestion(1, Properties.Resources.PlanetaMercurio, "¿Que planeta es el más cercano al sol?", new List<string> { "Venues", "Mercurio", "Marte" }, 1);
            SetQuestion(2, Properties.Resources.OsoAnteojos, "¿Que animal es el unico oso nativo de Sudamerica?", new List<string> { "Oso pardo", "Oso polar", "Oso de anteojos" }, 2);
            SetQuestion(3, Properties.Resources.PlanetaJupiter, "¿Que planeta es el más grande del sistema solar?", new List<string> { "Saturno", "Júpiter", "Neptuno" }, 1);
            SetQuestion(4, Properties.Resources.GatoAndino, "¿Que animal es el más pequeño de la familia de los felinos?", new List<string> { "Gato andino", "Trigrillo", "Gato montes" }, 0);

            viewQuestion(3, name);
        }

        //Mostramos la pregunta selecciona en la pantalla
        private void viewQuestion(int idQuestion, string name)
        {   //para evitar errores y tener una mejor experiencia de usuario se verifica si la pregunta existe
            if (Questions.ContainsKey(idQuestion))
            {   
                TriviaItem quiestion = Questions[idQuestion];
                // Asignamos las partes de las preguntas a los elementos visuales del form
                imageTrivia.Image = quiestion.Imagen;
                QuiestionTrivia.Text = $"Trivia para {name}: \n{quiestion.Question}";
                btnTrivia1.Text = quiestion.Options[0];
                btnTrivia2.Text = quiestion.Options[1];
                btnTrivia3.Text = quiestion.Options[2];
                // Asignamos el indicador de la respuesta correcta a la variable indexCorrectOption 
                correctOption = quiestion.Options[quiestion.CorrectOpciton];
            } else
            {   //se notifica al usuario del el error
                MessageBox.Show("La pregunta que se trata de mostrar no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Se realiza la creacion del instancia en el diccionario Questions
        private void SetQuestion(int idQuestion, Image image, string question, List<string> options,  int correctOpcition)
        {
            Questions[idQuestion] = new TriviaItem
            {
                Imagen = image,
                Question = question,
                Options = options,
                CorrectOpciton = correctOpcition
            };
        }

        // Metodo que es llamado cada vez que el conometo oscila 
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeCronometro--; //Se resta el cronometro
            //Actualizamos el label con los segundos
            valueTime.Text = timeCronometro.ToString();

            //Verificamos si llego a 0 seg
            if (timeCronometro == 0)
            {
                // Detén el temporizador
                timer1.Enabled = false;
                // Realiza la acción cuando el contador llega a 0
                EndTime();
            }
        }

        private void btnTrivia1_Click(object sender, EventArgs e)
        {   
            //verificamos si es la acción correcta
            isOptionCorrect(btnTrivia1);
        }

        private void btnTrivia2_Click(object sender, EventArgs e)
        {   
            //verificamos si es la accion correcta
            isOptionCorrect(btnTrivia2);
        }

        private void btnTrivia3_Click(object sender, EventArgs e)
        {   
            //verificamos si es la accion correcta
            isOptionCorrect(btnTrivia3);
        }

        //verifica si la respuesta correcta utilizado al objeto Button 
        private void isOptionCorrect(Button button)
        {   
            //comparo si es igual correctOption a el texto del boton
            if (correctOption == button.Text)
            {
                showCorrectOption(); 
            }
            else
            {
                showIncorrectOption();
            }
        }

        private void showCorrectOption()
        {
            if(this.MdiParent is appStrart app)
            {
                opcCorrect opcCorrect = new opcCorrect();
                opcCorrect.Width = app.ClientSize.Width - 4;
                opcCorrect.Height = app.ClientSize.Height - 4;
                opcCorrect.MdiParent = app;
                opcCorrect.Show();
                this.Close(); // cierro esta instancia de Play
            }
        }

        private void showIncorrectOption()
        {
            MessageBox.Show("Opcion Incorrecta");
        }

        private void EndTime()
        {
            // Aquí puedes realizar la acción que deseas cuando el contador llega a 0
            MessageBox.Show("¡El contador llegó a 0!");
        }
    }
}
