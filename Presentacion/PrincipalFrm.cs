using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Form ActivarFrom = null;
        private void AbrirFormularioHijo(Form formularioHijo)
        {
            if (ActivarFrom != null)
                ActivarFrom.Close();
            ActivarFrom = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(formularioHijo);
            PanelContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();

        }
        private void RegistrarBton_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new RegistrarFrm());
        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new ConsultarLiquidacionFrm());
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new ModificarLiquidacionFrm());
        }

        private void EliminarBton_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new EliminarLiquidacionFrm());
        }
    }
}
