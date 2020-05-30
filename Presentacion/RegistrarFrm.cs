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
    public partial class RegistrarFrm : Form
    {
        LiquidacionCuotaModeradoraService liquidacionS;
        Liquidacion liquidacion;
        public RegistrarFrm()
        {
            
            liquidacionS = new LiquidacionCuotaModeradoraService(ConfigConnection.connectionString);
            InitializeComponent();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            
           
            if (TipoAfiliacionBox.Text.Equals("Contributivo"))
            {
                liquidacion = new LiquidacionRegimenContributivo();
                liquidacion.Salario = Convert.ToInt64(SalarioTxt.Text);
            }
            else
            {
                liquidacion = new LiquidacionRegimenSubsidiado();
                liquidacion.Salario = 0;
            }
            liquidacion.Identificacion = IdentificacionTxt.Text;
            liquidacion.NumeroLiquidacion = NoLiquidacionTxt.Text;
            liquidacion.TipoAfiliacion = TipoAfiliacionBox.Text;
            liquidacion.ValorServicio = Convert.ToInt64(ValorServicioTxt.Text);
            liquidacion.Nombre = NombreTxt.Text;
            liquidacion.Fecha = FechaLiquidacion.Value.Date;
            liquidacion.CalcularTarifa();
            liquidacion.CalcularCuatoModeradora();
            liquidacion.CalcularTope();
            MessageBox.Show(liquidacionS.Guardar(liquidacion),"Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
