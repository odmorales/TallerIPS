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
        public override double CalcularCuotaModerada(long valorServicio, long salario)
        {
            double cuotaModerada;

            cuotaModerada = valorServicio * CalcularTarifa(salario);

            int cantidadSalario = CalcularEquivalenciaSalarioMinimo(salario);

            if ((cantidadSalario < 2) && (cuotaModerada > 250000))
            {
                return 250000;
            }
            else if (((cantidadSalario >= 2) || (cantidadSalario <= 5)) && (cuotaModerada > 900000))
            {
                return 900000;
            }
            else if (cantidadSalario > 5)
            {
                return 1500000;
            }
            else if ((cantidadSalario < 2) && (cuotaModerada < 250000))
            {
                return cuotaModerada;

            }
            else if (((cantidadSalario >= 2) || (cantidadSalario <= 5)) && (cuotaModerada < 1500000))
            {
                return cuotaModerada;
            }

            return cuotaModerada;
        }

       
        
        public int  CalcularEquivalenciaSalarioMinimo(long salario)
        {
            int cantidadSalario;

            cantidadSalario = Convert.ToInt32(salario / SALARIOMINIMO);

            return cantidadSalario;
        }

        public override double CalcularTarifa(long salario)
        {
            int cantidadSalario = CalcularEquivalenciaSalarioMinimo(salario);

            if (cantidadSalario < 2)
            {
                return 0.15;
            }
            else if ((cantidadSalario >= 2) || (cantidadSalario <= 5))
            {
                return 0.2;
            }

            return 0.25;

        }
    }
}
