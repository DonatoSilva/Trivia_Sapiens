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
    public partial class appStrart : Form
    { 
        public appStrart()
        {
            InitializeComponent();
            //Obtengo el tamaño de la aplicacion
            int width = this.ClientSize.Width - 4;
            int height = this.ClientSize.Height - 4;
            ///Inicio la app en Index pasandole la resolucion de la pantalla
            showIndex(width, height);
        }

        private void showIndex(int width, int height)
        {
            Index index = new Index();
            index.MdiParent = this;
            index.Width = width;
            index.Height = height;
            index.Show();
        }
    }
}
