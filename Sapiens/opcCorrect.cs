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

namespace Sapiens
{
    public partial class opcCorrect : Form
    {
        private SoundPlayer sound;
        public opcCorrect()
        {
            InitializeComponent();
            //Se asigna el sonido para con el evento del componen reproducirlo
            sound = new SoundPlayer(Properties.Resources.Aplausos);
        }

        private void opcCorrect_Load(object sender, EventArgs e)
        {
            sound.Play();
        }
    }
}
