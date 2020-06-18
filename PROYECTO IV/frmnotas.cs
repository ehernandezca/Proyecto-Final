using NPOI.XWPF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_IV
{
    public partial class frmnotas : Form
    {
        public frmnotas()
        {
            InitializeComponent();
            txtruta.Visible = false;
            txtnombre.Visible = false;
            btnguardar.Visible = false;
            label1.Visible = false;
            txtbloc.Focus();
        }

        private void GuardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnguardar.Visible = true;
            txtnombre.Visible = true;
            label1.Visible = true;

        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            notasbloc.guardar(txtbloc, txtruta, txtnombre);        
            this.Hide();
        }

        private void NuevaVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnotas a = new frmnotas();
            a.Show();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}