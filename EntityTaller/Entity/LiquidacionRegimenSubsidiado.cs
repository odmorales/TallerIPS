using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LiquidacionRegimenSubsidiado : Liquidacion
    {
        public override void CalcularCuatoModeradora()
        {
            CalcularTarifa(Salario);
            CuotaModerada = ValorServicio * Tarifa;

        }

        public override void CalcularTope(long salario)
        {
            if (CuotaModerada > 200000)
            {
                Tope = 200000;
            }
            Tope = 0;
        }
        public override void CalcularTarifa(long salario)
        {
            Tarifa = 0.5;
        }
    }
}
