using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sapiens
{
    public partial class opcIncorrect : Form
    {
        private SoundPlayer sound;
        private string name;
        private int numberCorrect;
        private int numberQuiestion;
        public opcIncorrect(string name, int numberQuiestion, int numberCorrect)
        {
            InitializeComponent();
            textTitleMessage.Text = $"¡Nooooo!, que paso {name}";
            this.numberCorrect = numberCorrect;
            this.numberQuiestion = numberQuiestion;
            this.name = name;
            //Se asigna el sonido para con el evento del componen reproducirlo
            sound = new SoundPlayer(Properties.Resources.Equivocado);
        }

        private void opcIncorrect_Load(object sender, EventArgs e)
        {
            sound.Play();
        }

        private void BtnNextQuestion_Click(object sender, EventArgs e)
        {
            if (numberQuiestion != 4)
            {

                // Obtén una referencia al formulario MDI principal
                if (this.MdiParent is appStrart app)
                {
                    Play play = new Play(this.name, (this.numberQuiestion + 1), this.numberCorrect); // Crea una instancia de Play
                    play.Width = app.ClientSize.Width - 4;
                    play.Height = app.ClientSize.Height - 4;
                    play.MdiParent = app; // Establece el formulario MDI principal como el padre de play
                    play.Show(); // Muestra play
                    this.Close(); // Cerramos la instancia actual de index
                }
            }
            else
            {
                // Obtén una referencia al formulario MDI principal
                if (this.MdiParent is appStrart app)
                {
                    endPlay endPlay = new endPlay();
                    endPlay.Width = app.ClientSize.Width - 4;
                    endPlay.Height = app.ClientSize.Height - 4;
                    endPlay.MdiParent = app; // Establece el formulario MDI principal como el padre de play
                    endPlay.Show(); // Muestra play
                    this.Close(); // Cerramos la instancia actual de index
                }
            }
        }

        private void BtnShowIndex_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is appStrart app)
            {
                Index index = new Index();
                index.MdiParent = app;
                index.Width = app.ClientSize.Width - 4;
                index.Height = app.ClientSize.Height - 4;
                index.Show();
                this.Close();
            }
        }
    }
}
