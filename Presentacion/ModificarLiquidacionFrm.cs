﻿using System;
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
        LiquidacionCuotaModeradoraService liquidacion;
        Liquidacion liquidacion1;
        public ModificarLiquidacionFrm()
        {
            liquidacion = new LiquidacionCuotaModeradoraService(ConfigConnection.connectionString);
            InitializeComponent();
        }

       
        private void ModificarBton_Click(object sender, EventArgs e)
        {
            RespuestaBuscar respuesta = new RespuestaBuscar();
            respuesta = liquidacion.Buscar(NoLiquidacionTxt.Text);
            MessageBox.Show(respuesta.Mensaje,"Descripcion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            MessageBox.Show(liquidacion.Modificar(respuesta.liquidacion), "Descripcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liquidacion1.CalcularTarifa();
            liquidacion1.CalcularCuatoModeradora();
            liquidacion1.CalcularTope();
        }
    }
}
