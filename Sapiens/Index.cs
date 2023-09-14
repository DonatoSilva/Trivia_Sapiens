using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sapiens
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void btnInf_Click(object sender, EventArgs e)
        {
            String menssage = "¡Hola a todos! 😃🎉\r\n\r\nSoy Donato Silva, el desarrollador de esta increíble trivia. Estoy más feliz que nunca de verlos utilizando esta aplicación. 🙌💻\r\n\r\nEspero que estén disfrutando de cada pregunta y desafiándose a sí mismos para obtener las respuestas correctas. \U0001f9e0🤓\r\n\r\n¡Gracias por ser parte de esta experiencia! 💙🌟\r\n\r\nSiéntanse libres de seguir explorando y divirtiéndose con la trivia. ¡Estoy aquí para ayudar en caso de que necesiten algo! 😄🎈";
            // Mostrar un cuadro de diálogo de mensaje
            MessageBox.Show(menssage, "Saludo a todos 🫂", MessageBoxButtons.OK);
        }

        private void BtnPlay(object sender, EventArgs e)
        {   
            String name = txtName.Text.Trim();
            if (!String.IsNullOrEmpty(name))
            {
                // Obtén una referencia al formulario MDI principal
                if (this.MdiParent is appStrart app)
                {
                    Play play = new Play(name, 1, 0); // Crea una instancia de Play
                    play.Width = app.ClientSize.Width - 4;
                    play.Height = app.ClientSize.Height - 4;
                    play.MdiParent = app; // Establece el formulario MDI principal como el padre de play
                    play.Show(); // Muestra play
                    this.Close(); // Cerramos la instancia actual de index
                }
            } else {
                MessageBox.Show("El nombre no puede estar vacio", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        //Jugamos con los eventos del btnPlay para darle mas vida al codigo
        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            btnPlay.Text = "Vamonos...";
        }
        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.Text = "Jugar";
        }
    }
}
