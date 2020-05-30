using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Presentacion
{
    public partial class EliminarLiquidacionFrm : Form
    {
        LiquidacionCuotaModeradoraService liquidacion;
        
        public EliminarLiquidacionFrm()
        {
            liquidacion = new LiquidacionCuotaModeradoraService(ConfigConnection.connectionString);
            InitializeComponent();
        }

        private void BuscarBton_Click(object sender, EventArgs e)
        {
            liquidacion.Buscar(NoLiquidacionTxt.Text);
        }

        private void ModificarBton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(liquidacion.Eliminar(NoLiquidacionTxt.Text), "Descripcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
