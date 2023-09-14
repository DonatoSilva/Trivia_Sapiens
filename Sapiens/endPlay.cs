using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sapiens
{
    public partial class endPlay : Form
    {
        private string Title;
        private string Result;
        private Image image;
        private string name;
        public endPlay(string name, int numberQuestion, int numberCorrect)
        {
            InitializeComponent();
            this.name = name;
            bool happy = (numberCorrect > numberQuestion / numberCorrect);
            this.image = happy ? Properties.Resources.ranuraFeliz2 : Properties.Resources.ranuraSorprendido;
            this.Title = happy ? $"Lo lograste {name}, pasaste la trivia" : $"Lastima {name}, no lograste pasar";
            this.Result =  $"Total correctas: {numberCorrect}\r\nTotal Incorrectas: {numberQuestion - numberCorrect}\r\nTotal Trivias: {numberQuestion}\r\n";

            showResult();
        }

        private void showResult()
        {
            textTitleMessage.Text = this.Title;
            textResult.Text = this.Result;
            imageResult.Image = this.image;

        }

        private void btnShowIndex_Click(object sender, EventArgs e)
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

        private void btnNewPlay_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.name))
            {
                showPlay(this.name, 1, 0);
            }
            else
            {
                MessageBox.Show("El nombre no puede estar vacio", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            void showPlay(string name, int numberQuestion, int numberCorrectQuestion)
            {
                // Obtén una referencia al formulario MDI principal
                if (this.MdiParent is appStrart app)
                {
                    Play play = new Play(name, numberQuestion, numberCorrectQuestion); // Crea una instancia de Play
                    play.Width = app.ClientSize.Width - 4;
                    play.Height = app.ClientSize.Height - 4;
                    play.MdiParent = app; // Establece el formulario MDI principal como el padre de play
                    play.Show(); // Muestra play
                    this.Close(); // Cerramos la instancia actual de index
                }
            }
        }
    }
}
