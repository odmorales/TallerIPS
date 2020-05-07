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
            CalcularTarifa();
            CuotaModerada = ValorServicio * Tarifa;

        }

        public override void CalcularTope()
        {
            if (CuotaModerada > 200000)
            {
                Tope = 200000;
            }
            Tope = 0;
        }
        public override void CalcularTarifa()
        {
            Tarifa = 0.5;
        }
    }
}
