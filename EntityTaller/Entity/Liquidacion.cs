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
        public double ValorServicio { get; set; }
        public double Tarifa { get; set; }
        public decimal CuotaModerada { get; set; }

        public abstract double CalcularCuotaModerada(long valorServicio,long salario);

        public abstract double CalcularTarifa(long salario);
        
         
        

    }
}
