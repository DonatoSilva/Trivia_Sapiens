using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sapiens
{
    public partial class opcCorrect : Form
    {
        private SoundPlayer sound;
        private int numberCorrect;
        private int numberQuiestion;
        private string name;
        public opcCorrect(string name, int numberQuiestion, int numberCorrect)
        {
            InitializeComponent();
            textTitleMessage.Text = $"!Felicidades! Super bien {name}";
            this.numberCorrect = numberCorrect;
            this.numberQuiestion = numberQuiestion;
            this.name = name;
            //Se asigna el sonido para con el evento del componen reproducirlo
            sound = new SoundPlayer(Properties.Resources.Aplausos);
        }

        private void opcCorrect_Load(object sender, EventArgs e)
        {
            sound.Play();
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

        private void BtnNextQuestion_Click(object sender, EventArgs e)
        {
            if (numberQuiestion != 4)
            {
                // Obtén una referencia al formulario MDI principal
                if (this.MdiParent is appStrart app)
                {
                    Play play = new Play(this.name, this.numberQuiestion + 1, this.numberCorrect + 1); // Crea una instancia de Play
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
                    endPlay endPlay = new endPlay(this.name, this.numberQuiestion, this.numberCorrect + 1);
                    endPlay.Width = app.ClientSize.Width - 4;
                    endPlay.Height = app.ClientSize.Height - 4;
                    endPlay.MdiParent = app; // Establece el formulario MDI principal como el padre de play
                    endPlay.Show(); // Muestra play
                    this.Close(); // Cerramos la instancia actual de index
                }
            }
        }
    }
}
