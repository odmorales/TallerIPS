using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LiquidacionRegimenContributivo : Liquidacion
    {

        const decimal SALARIOMINIMO = 877000;
        public override void CalcularCuatoModeradora()
        {
            CalcularTarifa();

            CuotaModerada = ValorServicio * Tarifa;

        }

        public override void CalcularTope()
        {
            int cantidadSalario = CalcularEquivalenciaSalarioMinimo(Salario);

            if ((cantidadSalario < 2) && (CuotaModerada > 250000))
            {
                Tope = 250000;
            }
            else if (((cantidadSalario >= 2) || (cantidadSalario <= 5)) && (CuotaModerada > 900000))
            {
                Tope = 900000;
            }
            else if(cantidadSalario > 5 && (CuotaModerada > 1500000))
            {
                Tope = 1500000;
            }

            Tope = 0;
        }


        public int  CalcularEquivalenciaSalarioMinimo(long salario)
        {
            int cantidadSalario;

            cantidadSalario = Convert.ToInt32(salario / SALARIOMINIMO);

            return cantidadSalario;
        }

        public override void CalcularTarifa()
        {
            int cantidadSalario = CalcularEquivalenciaSalarioMinimo(Salario);

            if (cantidadSalario < 2)
            {
                Tarifa = 0.15;
            }
            else if ((cantidadSalario >= 2) || (cantidadSalario <= 5))
            {
                Tarifa = 0.2;
            }

            Tarifa = 0.25;

        }
    }
}
