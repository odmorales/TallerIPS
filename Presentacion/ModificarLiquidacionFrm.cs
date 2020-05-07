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
    public partial class ModificarLiquidacionFrm : Form
    {
        LiquidacionCuotaModeradoraService liquidacion = new LiquidacionCuotaModeradoraService();
        public ModificarLiquidacionFrm()
        {
            InitializeComponent();
        }

       
        private void ModificarBton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(liquidacion.Modificar(liquidacion.Buscar(NoLiquidacionTxt.Text)),"Descripcion",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
