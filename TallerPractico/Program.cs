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
            Liquidacion liquidacion1 = new LiquidacionRegimenSubsidiado();

            List<LiquidacionRegimenContributivo> liquidacionRegimenContributivos = new List<LiquidacionRegimenContributivo>();
            List<LiquidacionRegimenSubsidiado> liquidacionRegimenSubsidiados = new List<LiquidacionRegimenSubsidiado>();
            LiquidacionCuotaModeradoraService liquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();

            int opcionLiquidacion;

            do
            {
                Console.WriteLine("---Menu---");
                Console.WriteLine("1. Liquidacion regimen contributibvo");
                Console.WriteLine("2. Liquidacion regimen subsidiado");
                Console.WriteLine("3. Salir");
                Console.Write("Opcion: ");
                opcionLiquidacion = Convert.ToInt32(Console.ReadLine());

                switch (opcionLiquidacion)
                {
                    case 1:

                        int opcionContributivo;

                        Console.WriteLine("---Menu---");
                        Console.WriteLine("1. Guardar");
                        Console.WriteLine("2. Consultar");
                        Console.WriteLine("3. Modificar");
                        Console.WriteLine("4. Eliminar");
                        Console.WriteLine("5. Salir");
                        Console.Write("Opcion: ");
                        opcionContributivo = Convert.ToInt32(Console.ReadLine());

                        switch (opcionContributivo)
                        {
                            case 1:

                                string opcionGuardar;

                                do
                                {

                                    Console.WriteLine("Digite el numero de liquidacion");
                                    liquidacion.NumeroLiquidacion = Console.ReadLine();
                                    Console.WriteLine("Digite la identificacion");
                                    liquidacion.Identificacion = Console.ReadLine();
                                    Console.WriteLine("Digite el salario devengado por el paciente");
                                    liquidacion.Salario = Convert.ToInt64(Console.ReadLine());
                                    Console.WriteLine("Digite el valor del servicio hospitalizacion prestado");
                                    liquidacion.ValorServicio = Convert.ToInt64(Console.ReadLine());

                                    liquidacion.ValorReal = liquidacion.CalcularCuatoModeradora(liquidacion.ValorServicio, liquidacion.Salario);
                                    liquidacion.CuotaModerada = liquidacion.CalcularTope(liquidacion.ValorServicio, liquidacion.Salario);
                                    liquidacion.Tarifa = liquidacion.CalcularTarifa(liquidacion.Salario);

                                    liquidacionCuotaModeradoraService.GuardarRegimenContributivo(liquidacion);

                                    Console.ReadKey();

                                    Console.WriteLine(" Desea guardar otro? S/N ");
                                    opcionGuardar = Console.ReadLine();
                                } while (opcionGuardar.ToUpper().Equals("S"));

                                 break;
                            case 2:

                                liquidacionRegimenContributivos = liquidacionCuotaModeradoraService.ConsultarRegimenContributivo();

                                foreach (var item in liquidacionRegimenContributivos)
                                {
                                    Console.WriteLine($"Numero Liquidacion: {item.NumeroLiquidacion} Identificaion: {item.Identificacion} " +
                                        $"Salario: {item.Salario} Valor del servicio: {item.ValorServicio} Valor real: {item.ValorReal} " +
                                        $"Cuota moderada: {item.CuotaModerada} Tarifa: {item.Tarifa}");
                                }

                                Console.ReadKey();

                                break;

                            case 3:
                                string numeroLiquidacion;
                                
                                Console.WriteLine("Ingrese el numero de liquidacion");
                                numeroLiquidacion = Console.ReadLine();

                                liquidacion = liquidacionCuotaModeradoraService.BuscarRegimenContributivo(numeroLiquidacion);

                                if (liquidacion != null)
                                {
                                    Console.WriteLine("Registro encontrado");
                                    Console.WriteLine("Digite el nuevo valor del servicio");
                                    liquidacion.ValorServicio = Convert.ToInt64(Console.ReadLine());

                                    liquidacion.ValorReal = liquidacion.CalcularCuatoModeradora(liquidacion.ValorServicio, liquidacion.Salario);
                                    liquidacion.CuotaModerada = liquidacion.CalcularTope(liquidacion.ValorServicio, liquidacion.Salario);
                                    liquidacion.Tarifa = liquidacion.CalcularTarifa(liquidacion.Salario);

                                    liquidacionCuotaModeradoraService.ModificarRegimenContributivo(liquidacion);

                                }

                                Console.ReadKey();
                                break;

                            case 4:

                                string numeroLiquidacionEliminar;

                                Console.WriteLine("Ingrese el numero de liquidacion");
                                numeroLiquidacionEliminar = Console.ReadLine();

                                string respuesta = liquidacionCuotaModeradoraService.EliminarRegimenContributivo(numeroLiquidacionEliminar);

                                Console.ReadKey();
                                break;

                            case 5:
                                Console.WriteLine(" GRACIAS POR UTILIZAR EL PROGRAMA ");
                                Console.ReadKey();
                                break;

                            default:
                                Console.WriteLine($"La opcion {opcionContributivo}, no se encuentra disponible. "); 
                                
                                break;     
                        }

                        break;

                    case 2:

                        int opcionSubsidiado;

                        Console.WriteLine("Menu");
                        Console.WriteLine("1.Guardar");
                        Console.WriteLine("2.Consultar");
                        Console.WriteLine("3. Modificar");
                        Console.WriteLine("4. Eliminar");
                        Console.WriteLine("5. Salir");
                        Console.Write("Opcion: ");

                        opcionSubsidiado = Convert.ToInt32(Console.ReadLine());
                        switch (opcionSubsidiado)
                        {
                            case 1:

                                string opcionGuardar;

                                do
                                {

                                    Console.WriteLine("Digite el numero de liquidacion");
                                    liquidacion1.NumeroLiquidacion = Console.ReadLine();
                                    Console.WriteLine("Digite la identificacion");
                                    liquidacion1.Identificacion = Console.ReadLine();
                                    liquidacion1.Salario = 0;
                                    Console.WriteLine("Digite el valor del servicio hospitalizacion prestado");
                                    liquidacion1.ValorServicio = Convert.ToInt64(Console.ReadLine());

                                    liquidacion1.ValorReal = liquidacion1.CalcularCuatoModeradora(liquidacion1.ValorServicio, liquidacion1.Salario);
                                    liquidacion1.CuotaModerada = liquidacion1.CalcularTope(liquidacion1.ValorServicio, liquidacion1.Salario);
                                    liquidacion1.Tarifa = liquidacion1.CalcularTarifa(liquidacion1.Salario);

                                    liquidacionCuotaModeradoraService.GuardarRegimenSubsidiado(liquidacion1);

                                    Console.ReadKey();

                                    Console.WriteLine(" Desea guardar otro? S/N ");
                                    opcionGuardar = Console.ReadLine();
                                } while (opcionGuardar.ToUpper().Equals("S"));

                                break;
                            case 2:

                                liquidacionRegimenSubsidiados = liquidacionCuotaModeradoraService.ConsultarRegimenSubsidiado();

                                foreach (var item in liquidacionRegimenSubsidiados)
                                {
                                    Console.WriteLine($"Numero Liquidacion: {item.NumeroLiquidacion} Identificaion: {item.Identificacion} " +
                                        $"Valor del servicio: {item.ValorServicio} Valor real: {item.ValorReal} " +
                                        $"Cuota moderada: {item.CuotaModerada} Tarifa: {item.Tarifa}");
                                }

                                Console.ReadKey();

                                break;

                            case 3:
                                string numeroLiquidacion;

                                Console.WriteLine("Ingrese el numero de liquidacion");
                                numeroLiquidacion = Console.ReadLine();

                                liquidacion = liquidacionCuotaModeradoraService.BuscarRegimenSubsidiado(numeroLiquidacion);

                                if (liquidacion != null)
                                {
                                    Console.WriteLine("Registro encontrado");
                                    Console.WriteLine("Digite el nuevo valor del servicio");
                                    liquidacion.ValorServicio = Convert.ToInt64(Console.ReadLine());

                                    liquidacion1.ValorReal = liquidacion1.CalcularCuatoModeradora(liquidacion1.ValorServicio, liquidacion1.Salario);
                                    liquidacion1.CuotaModerada = liquidacion1.CalcularTope(liquidacion1.ValorServicio, liquidacion1.Salario);
                                    liquidacion1.Tarifa = liquidacion1.CalcularTarifa(liquidacion1.Salario);

                                    liquidacionCuotaModeradoraService.ModificarRegimenSubsidiado(liquidacion1);

                                }

                                Console.ReadKey();
                                break;

                            case 4:

                                string numeroLiquidacionEliminar;

                                Console.WriteLine("Ingrese el numero de liquidacion");
                                numeroLiquidacionEliminar = Console.ReadLine();

                                string respuesta = liquidacionCuotaModeradoraService.EliminarRegimenSubsidiado(numeroLiquidacionEliminar);

                                Console.ReadKey();
                                break;

                            case 5:
                                Console.WriteLine(" GRACIAS POR UTILIZAR EL PROGRAMA ");
                                Console.ReadKey();
                                break;

                            default:
                                Console.WriteLine($"La opcion {opcionSubsidiado}, no se encuentra disponible. ");

                                break;
                        }

                        break;

  
                }

            } while (opcionLiquidacion != 3);

            
        }
    }
}
