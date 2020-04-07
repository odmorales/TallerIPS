using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;


namespace TallerPractico
{
    public class Program
    {
        static void Main(string[] args)
        {

            Liquidacion liquidacion = new LiquidacionRegimenContributivo();
            LiquidacionCuotaModeradoraService liquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();

            liquidacion.Identificacion = "123";
            liquidacion.NumeroLiquidacion = "1";
            liquidacion.Salario = 900000;
            liquidacion.TipoAfiliacion = "Contribuyente";
            liquidacion.ValorServicio = 250000;

            liquidacion.ValorReal = liquidacion.CalcularLiquidacion(liquidacion.ValorServicio, liquidacion.Salario);
            liquidacion.CuotaModerada = liquidacion.CalcularValorReal(liquidacion.ValorServicio, liquidacion.Salario);
            liquidacion.Tarifa = liquidacion.CalcularTarifa(liquidacion.Salario);



            liquidacionCuotaModeradoraService.GuardarRegimenContributivo(liquidacion);

            //liquidacion = liquidacionCuotaModeradoraService.BuscarRegimenContributivo("1");

            //if (liquidacion != null)
            //{
            //    Console.WriteLine("Encontrado");

            //    liquidacion.ValorServicio = 340000;

            //    liquidacion.ValorReal = liquidacion.CalcularLiquidacion(liquidacion.ValorServicio, liquidacion.Salario);
            //    liquidacion.CuotaModerada = liquidacion.CalcularValorReal(liquidacion.ValorServicio, liquidacion.Salario);
            //    liquidacion.Tarifa = liquidacion.CalcularTarifa(liquidacion.Salario);

            //    liquidacionCuotaModeradoraService.ModificarRegimenContributivo(liquidacion);
            //}
            //else
            //{
            //    Console.WriteLine("No existe");
            //}



            Console.ReadKey();
        }
    }
}
