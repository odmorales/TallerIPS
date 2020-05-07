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

        private IList<Liquidacion> lista;

        public LiquidacionCuotaModeradoraRepository()
        {
            lista = new List<Liquidacion>();
        }

        public void Guardar(Liquidacion liquidacion)
        {
            FileStream fileStream = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(fileStream);

            escritor.WriteLine($"{liquidacion.Identificacion};{liquidacion.NumeroLiquidacion};{liquidacion.Salario};" +
                $"{liquidacion.Tarifa};{liquidacion.TipoAfiliacion};{liquidacion.ValorServicio};" +
                $"{liquidacion.CuotaModerada};{liquidacion.ValorReal};{liquidacion.Nombre};{liquidacion.Fecha}" +
                $";{liquidacion.Tope}");

            escritor.Close();
            fileStream.Close();

        }
        public IList<Liquidacion> Consultar()
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
                liquidacion.Nombre = Datos[8];
                liquidacion.Fecha = Convert.ToDateTime(Datos[9]);
                liquidacion.Tope = Convert.ToInt64(Datos[10]);

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

            return lista.Where(l => l.NumeroLiquidacion.Equals(numeroLiquidacion)).FirstOrDefault();
        }

        public int TotalPorLiquidacion(string tipo)
        {
            lista = Consultar();

            return lista.Where(l => l.TipoAfiliacion.Equals(tipo)).Count();
        }
        public double TotalCuotaModeradora(string tipo)
        {
            lista = Consultar();

            return lista.Where(l => l.TipoAfiliacion.Equals(tipo)).Sum(l => l.CuotaModerada);
        }
        public IList<Liquidacion> FiltrarPorFecha(int Mes, int Anio)
        {
            lista = Consultar();
            return lista.Where(l => ((l.Fecha.Year) == Anio && (l.Fecha.Month == Mes))).ToList();
        }

        public IList<Liquidacion> ConsultarPorPalabra(string palabra)
        {
            lista = Consultar();
            return lista.Where(l => l.Nombre.Contains(palabra)).ToList();
        }
        public int TotalLiquidacionTodos()
        {
            lista = Consultar();
            return lista.Count();
        }
        public double TotalCuotaModeradoraTodos()
        {
            lista = Consultar();
            return lista.Sum(l => l.CuotaModerada);
        }
    }
}
