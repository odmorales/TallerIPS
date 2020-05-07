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
    public partial class ConsultarLiquidacionFrm : Form
    {
        LiquidacionCuotaModeradoraService liquidacion = new LiquidacionCuotaModeradoraService();
        IList<Liquidacion> lista;
        public ConsultarLiquidacionFrm()
        {
            InitializeComponent();
        }

        

        private void CalcularBton_Click(object sender, EventArgs e)
        {
            if(TipoCalculoBox.Text.Equals("Suma") && TipoBox.Text.Equals("Todos"))
            {
                TotalTodostxt.Text = (liquidacion.TotalLiquidacionTodos()).ToString();
            }else if(TipoCalculoBox.Text.Equals("Totales") && TipoBox.Text.Equals("Todos"))
            {
                TotalTodostxt.Text = (liquidacion.TotalCuotaModeradoraTodos()).ToString();
            }else if (TipoCalculoBox.Text.Equals("Suma") && TipoBox.Text.Equals("Subsidiado"))
            {
                SubsidiadoTxt.Text = (liquidacion.TotalporLiquidacion("Subsidiado")).ToString();
            }else if (TipoCalculoBox.Text.Equals("Suma") && TipoBox.Text.Equals("Contributivo"))
            {
                Contributivotxt.Text = (liquidacion.TotalporLiquidacion("Contributivo")).ToString();
            }else if (TipoCalculoBox.Text.Equals("Totales") && TipoBox.Text.Equals("Subsidiado"))
            {
                SubsidiadoTxt.Text = (liquidacion.TotalCuotaModeradora("Subsidiado")).ToString();
            }else if (TipoCalculoBox.Text.Equals("Totales") && TipoBox.Text.Equals("Contributivo"))
            {
                Contributivotxt.Text = (liquidacion.TotalCuotaModeradora("Contributivo")).ToString();
            }else if (TipoCalculoBox.Text.Equals("FiltrarPorFecha"))
            {
                lista = liquidacion.FiltrarPorFecha(FechaDt.Value.Month, FechaDt.Value.Year);
                dataGridView1.DataSource = lista;
            }else if (TipoCalculoBox.Text.Equals("BuscarPalabra"))
            {
                lista = liquidacion.ConsultarPorPalabra(PalabraTxt.Text);
                dataGridView1.DataSource = lista;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            RespuestaConsulta respuesta = new RespuestaConsulta();
            if (TipoBox.Text.Equals("Todos"))
            {
                respuesta = liquidacion.Consultar();
                
                dataGridView1.DataSource = respuesta.Lista;
            }else if (TipoBox.Text.Equals("Contributivo"))
            {
                
                dataGridView1.DataSource = liquidacion.FiltrarPorTipo("Contributivo");

            }
            else if(TipoBox.Text.Equals("Subsidiado"))
            {
                
                dataGridView1.DataSource = liquidacion.FiltrarPorTipo("Subsidiado");
            }
        }
    }
}
