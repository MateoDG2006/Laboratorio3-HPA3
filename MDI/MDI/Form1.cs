using System;
using System.Drawing;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form1 : Form
    {
        private int numeroVentana;

        public Form1()
        {
            InitializeComponent();
        }

        private void NuevaVentana_Click(object sender, EventArgs e)
        {
            Form ventana = new Form
            {
                MdiParent = this,
                Text = "Ventana " + (++numeroVentana),
                ClientSize = new Size(400, 250)
            };

            ventana.Show();
        }

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            ActiveMdiChild?.Close();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cascada_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MosaicoHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MosaicoVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
