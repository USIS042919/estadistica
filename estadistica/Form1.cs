using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estadistica
{
    public partial class Form1 : Form
        
    {
        estadistica objestadistica = new estadistica();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmedia_aritmetica_Click(object sender, EventArgs e)
        {
            //split =>divide una cadena en base aun delimitador (patron) y vuelve una matriz
            lblrespuesta_serie.Text = "x="+ objestadistica.media(txtserie.Text.Split(','));
        }
    }
}
