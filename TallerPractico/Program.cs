using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace TallerPractico
{
    public class Program
    {
        static void Main(string[] args)
        {

            Liquidacion liquidacion = new LiquidacionRegimenContributivo();

            Liquidacion liquidacion1 = new LiquidacionRegimenSubsidiado();

            Console.WriteLine($"Usted debe pagar: {liquidacion.CalcularCuotaModerada(250000, 879000)}");

            Console.WriteLine($"Usted debe pagar: {liquidacion.CalcularCuotaModerada(2500000, 2631000)}");

            Console.WriteLine($"Usted debe pagar: {liquidacion.CalcularCuotaModerada(5500000, 2631000)}");

            Console.WriteLine($"Usted debe pagar: {liquidacion.CalcularCuotaModerada(550000, 263100000)}");

            Console.WriteLine($"Usted debe pagar: {liquidacion1.CalcularCuotaModerada(250000, 0)}");

            Console.WriteLine($"Usted debe pagar: {liquidacion1.CalcularCuotaModerada(500000, 0)}");


            Console.ReadKey();

        }
    }
}
