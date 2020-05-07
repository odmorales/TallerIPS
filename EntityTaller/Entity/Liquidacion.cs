using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Liquidacion
    {
        public string NumeroLiquidacion { get; set; }
        public string Identificacion { get; set; }
        public string TipoAfiliacion { get; set; }
        public long Salario { get; set; }
        public long Tope { get; set; }
        public long ValorServicio { get; set; }
        public double Tarifa { get; set; }
        public double CuotaModerada { get; set; }
        public double ValorReal { get; set; }

        public abstract void CalcularCuatoModeradora();

        public abstract void CalcularTope();

        public abstract void CalcularTarifa();
        
         
        

    }
}
