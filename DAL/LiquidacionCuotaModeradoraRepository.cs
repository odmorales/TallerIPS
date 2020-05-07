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

        

        private string ruta = "Liquidacion.txt";

        private List<Liquidacion> lista;

        public LiquidacionCuotaModeradoraRepository()
        {
            lista = new List<Liquidacion>();
        }

        public void Guardar(Liquidacion liquidacionRegimenContributivo)
        {
            FileStream fileStream = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(fileStream);

            escritor.WriteLine($"{liquidacionRegimenContributivo.Identificacion};{liquidacionRegimenContributivo.NumeroLiquidacion};{liquidacionRegimenContributivo.Salario};" +
                $"{liquidacionRegimenContributivo.Tarifa};{liquidacionRegimenContributivo.TipoAfiliacion};{liquidacionRegimenContributivo.ValorServicio};" +
                $"{liquidacionRegimenContributivo.CuotaModerada};{liquidacionRegimenContributivo.ValorReal}");

            escritor.Close();
            fileStream.Close();

        }
        public List<Liquidacion> Consultar()
        {

            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader leer = new StreamReader(fileStream);

            string Linea = string.Empty;
            Linea = leer.ReadLine();
            Linea = Mapear(leer);

            leer.Close();
            fileStream.Close();

            return lista;
        }

        private string Mapear(StreamReader leer)
        {
            string Linea;
            Liquidacion liquidacion;
            while ((Linea = leer.ReadLine()) != null)
            {
                char delimiter = ';';
                string[] Datos = Linea.Split(delimiter);
                liquidacion = Liquidar(Datos);

                liquidacion.Identificacion = Datos[0];
                liquidacion.NumeroLiquidacion = Datos[1];
                liquidacion.Salario = Convert.ToInt64(Datos[2]);
                liquidacion.Tarifa = Convert.ToDouble(Datos[3]);
                liquidacion.TipoAfiliacion = Datos[4];
                liquidacion.ValorServicio = Convert.ToInt64(Datos[5]);
                liquidacion.CuotaModerada = Convert.ToDouble(Datos[6]);
                liquidacion.ValorReal = Convert.ToDouble(Datos[7]);

                lista.Add(liquidacion);
            }

            return Linea;
        }

        private static Liquidacion Liquidar(string[] Datos)
        {
            Liquidacion liquidacion;
            if (Datos[4].Equals("Contribuyente"))
            {
                liquidacion = new LiquidacionRegimenContributivo();
            }
            else
            {
                liquidacion = new LiquidacionRegimenSubsidiado();
            }

            return liquidacion;
        }

        public void Eliminar(string numeroLiquidacion)
        {

            lista = Consultar();

            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();

            foreach (var item in lista)
            {
                if(item.NumeroLiquidacion != numeroLiquidacion)
                {
                    Guardar(item);
                }
            }
        }

        public void Modificar(Liquidacion liquidacion)
        {
            lista = Consultar();

            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();

            foreach (var item in lista)
            {
                if (item.NumeroLiquidacion.Equals(liquidacion.NumeroLiquidacion))
                {
                    Guardar(liquidacion);
                }
                else
                {
                    Guardar(item);
                }
            }
        }
         public Liquidacion Buscar(string numeroLiquidacion)
        {
            lista = Consultar();

            foreach (var item in lista)
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
