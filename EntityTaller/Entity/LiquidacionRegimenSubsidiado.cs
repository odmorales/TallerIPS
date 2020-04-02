using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LiquidacionRegimenSubsidiado : Liquidacion
    {
        public override double CalcularCuotaModerada(long valorServicio,long salario)
        {
            double cuotaModerada;

            cuotaModerada = valorServicio * CalcularTarifa(salario);

            if(cuotaModerada > 200000)
            {
                return 200000;
            }

            return cuotaModerada;
        }

        public override double CalcularTarifa(long salario)
        {
            return 0.5;
        }
    }
}
