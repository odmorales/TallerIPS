using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class LiquidacionCuotaModeradoraRepository
    {

        private string rutaSubsiadiado = "LiquidacionSubsiadiado.txt";

        private string rutaContribuyente = "LiquidacionContribuyente.txt";

        private List<LiquidacionRegimenContributivo> listaContributivo;

        private List<LiquidacionRegimenSubsidiado> listaSubsidiado;

        public void GuardarRegimenContributivo(Liquidacion liquidacionRegimenContributivo)
        {
            FileStream fileStream = new FileStream(rutaContribuyente, FileMode.Append);
            StreamWriter escritor = new StreamWriter(fileStream);

            escritor.WriteLine($"{liquidacionRegimenContributivo.Identificacion};{liquidacionRegimenContributivo.NumeroLiquidacion};{liquidacionRegimenContributivo.Salario};" +
                $"{liquidacionRegimenContributivo.Tarifa};{liquidacionRegimenContributivo.TipoAfiliacion};{liquidacionRegimenContributivo.ValorServicio};" +
                $"{liquidacionRegimenContributivo.CuotaModerada};{liquidacionRegimenContributivo.ValorReal}");

            escritor.Close();
            fileStream.Close();

        }
        public List<LiquidacionRegimenContributivo> ConsultarRegimenContributivo()
        {

            listaContributivo = new List<LiquidacionRegimenContributivo>();

            FileStream fileStream = new FileStream(rutaContribuyente, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader leer = new StreamReader(fileStream);

            string Linea = string.Empty;
            Linea = leer.ReadLine();
            while ((Linea = leer.ReadLine()) != null)
            {
                LiquidacionRegimenContributivo liquidacionRegimenContributivo = new LiquidacionRegimenContributivo();

                char delimiter = ';';
                string[] DatosRegimenContribuyente = Linea.Split(delimiter);

                liquidacionRegimenContributivo.Identificacion = DatosRegimenContribuyente[0];
                liquidacionRegimenContributivo.NumeroLiquidacion = DatosRegimenContribuyente[1];
                liquidacionRegimenContributivo.Salario = Convert.ToInt64(DatosRegimenContribuyente[2]);
                liquidacionRegimenContributivo.Tarifa = Convert.ToDouble(DatosRegimenContribuyente[3]);
                liquidacionRegimenContributivo.TipoAfiliacion = DatosRegimenContribuyente[4];
                liquidacionRegimenContributivo.ValorServicio = Convert.ToInt64(DatosRegimenContribuyente[5]);
                liquidacionRegimenContributivo.CuotaModerada = Convert.ToDouble(DatosRegimenContribuyente[6]);
                liquidacionRegimenContributivo.ValorReal = Convert.ToDouble(DatosRegimenContribuyente[7]);

                listaContributivo.Add(liquidacionRegimenContributivo);
            }

            leer.Close();
            fileStream.Close();

            return listaContributivo;

        }

        public void EliminarRegimenContributivo(string numeroLiquidacion)
        {

            listaContributivo = ConsultarRegimenContributivo();

            FileStream fileStream = new FileStream(rutaContribuyente, FileMode.Create);
            fileStream.Close();

            foreach (var item in listaContributivo)
            {
                if(item.NumeroLiquidacion != numeroLiquidacion)
                {
                    GuardarRegimenContributivo(item);
                }
            }
        }

        public void ModificarRegimenContributivo(Liquidacion liquidacionRegimenContributivo)
        {
            listaContributivo = ConsultarRegimenContributivo();

            FileStream fileStream = new FileStream(rutaContribuyente, FileMode.Create);
            fileStream.Close();

            foreach (var item in listaContributivo)
            {
                if (item.NumeroLiquidacion.Equals(liquidacionRegimenContributivo.NumeroLiquidacion))
                {
                    GuardarRegimenContributivo(liquidacionRegimenContributivo);
                }
                else
                {
                    GuardarRegimenContributivo(item);
                }
            }
        }
         public LiquidacionRegimenContributivo Buscar(string numeroLiquidacion)
        {
            listaContributivo = ConsultarRegimenContributivo();

            foreach (var item in listaContributivo)
            {
                if (item.NumeroLiquidacion.Equals(numeroLiquidacion))
                {
                    return item;
                }
            }

            return null;
        }

        public void GuardarRegimenSubsidiado(Liquidacion liquidacionRegimenSubsidiado)
        {
            FileStream fileStream = new FileStream(rutaSubsiadiado, FileMode.Append);
            StreamWriter escritor = new StreamWriter(fileStream);

            escritor.WriteLine($"{liquidacionRegimenSubsidiado.Identificacion};{liquidacionRegimenSubsidiado.NumeroLiquidacion};{liquidacionRegimenSubsidiado.Salario};" +
                $"{liquidacionRegimenSubsidiado.Tarifa};{liquidacionRegimenSubsidiado.TipoAfiliacion};{liquidacionRegimenSubsidiado.ValorServicio};" +
                $"{liquidacionRegimenSubsidiado.CuotaModerada};{liquidacionRegimenSubsidiado.ValorReal}");

            escritor.Close();
            fileStream.Close();
        }

        public List<LiquidacionRegimenSubsidiado> ConsultarRegimenSubsidiado()
        {
            listaSubsidiado = new List<LiquidacionRegimenSubsidiado>();

            FileStream fileStream = new FileStream(rutaSubsiadiado, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader leer = new StreamReader(fileStream);

            string Linea = string.Empty;
            Linea = leer.ReadLine();
            while ((Linea = leer.ReadLine()) != null)
            {
                LiquidacionRegimenSubsidiado liquidacionRegimenSubsidiado = new LiquidacionRegimenSubsidiado();

                char delimiter = ';';
                string[] DatosRegimenContribuyente = Linea.Split(delimiter);

                liquidacionRegimenSubsidiado.Identificacion = DatosRegimenContribuyente[0];
                liquidacionRegimenSubsidiado.NumeroLiquidacion = DatosRegimenContribuyente[1];
                liquidacionRegimenSubsidiado.Salario = Convert.ToInt64(DatosRegimenContribuyente[2]);
                liquidacionRegimenSubsidiado.Tarifa = Convert.ToDouble(DatosRegimenContribuyente[3]);
                liquidacionRegimenSubsidiado.TipoAfiliacion = DatosRegimenContribuyente[4];
                liquidacionRegimenSubsidiado.ValorServicio = Convert.ToInt64(DatosRegimenContribuyente[5]);
                liquidacionRegimenSubsidiado.CuotaModerada = Convert.ToDouble(DatosRegimenContribuyente[6]);
                liquidacionRegimenSubsidiado.ValorReal = Convert.ToDouble(DatosRegimenContribuyente[7]);

                listaSubsidiado.Add(liquidacionRegimenSubsidiado);
            }

            leer.Close();
            fileStream.Close();

            return listaSubsidiado;
        }
        public void EliminarRegimenSubsidiado(string numeroLiquidacion)
        {

            listaSubsidiado = ConsultarRegimenSubsidiado();

            FileStream fileStream = new FileStream(rutaSubsiadiado, FileMode.Create);
            fileStream.Close();

            foreach (var item in listaSubsidiado)
            {
                if (item.NumeroLiquidacion != numeroLiquidacion)
                {
                    GuardarRegimenSubsidiado(item);
                }
            }
        }

        public void ModificarRegimenSubsidiado(Liquidacion liquidacionRegimenSubsidiado)
        {
            listaSubsidiado = ConsultarRegimenSubsidiado();

            FileStream fileStream = new FileStream(rutaSubsiadiado, FileMode.Create);
            fileStream.Close();

            foreach (var item in listaSubsidiado)
            {
                if (item.NumeroLiquidacion.Equals(liquidacionRegimenSubsidiado.NumeroLiquidacion))
                {
                    GuardarRegimenContributivo(liquidacionRegimenSubsidiado);
                }
                else
                {
                    GuardarRegimenSubsidiado(item);
                }
            }
        }
        public LiquidacionRegimenSubsidiado BuscarSubsidiado(string numeroLiquidacion)
        {
            listaSubsidiado = ConsultarRegimenSubsidiado();

            foreach (var item in listaSubsidiado)
            {
                if (item.NumeroLiquidacion.Equals(numeroLiquidacion))
                {
                    return item;
                }
            }

            return null;
        }
    }
}
