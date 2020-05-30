using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;
using System.Data.SqlClient;

namespace DAL
{
    public class LiquidacionCuotaModeradoraRepository
    {
           
        
        SqlConnection connection;
        private IList<Liquidacion> lista;

        public LiquidacionCuotaModeradoraRepository(ConnectionManager connectionManager)
        {
            connection = connectionManager.connection;
        }
        public void Guardar(Liquidacion liquidacion)
        {
            
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Liquidacion (NumeroLiquidacion,Identificaion,Salario,Tarifa,TipoAfiliacion," +
                                    "ValorServicio,CuotaModerada,ValorReal,Nombre,Fecha,Tope) values(@NumeroLiquidacion,@Identificaion,@Salario,@Tarifa,@TipoAfiliacion," +
                                    "@ValorServicio,@CuotaModerada,@ValorReal,@Nombre,@Fecha,@Tope)";
                command.Parameters.AddWithValue("@NumeroLiquidacion", liquidacion.NumeroLiquidacion);
                command.Parameters.AddWithValue("@Identificaion", liquidacion.Identificacion);
                command.Parameters.AddWithValue("@Salario", liquidacion.Salario);
                command.Parameters.AddWithValue("@Tarifa", liquidacion.Tarifa);
                command.Parameters.AddWithValue("@TipoAfiliacion", liquidacion.TipoAfiliacion);
                command.Parameters.AddWithValue("@ValorServicio", liquidacion.ValorServicio);
                command.Parameters.AddWithValue("@CuotaModerada", liquidacion.CuotaModerada);
                command.Parameters.AddWithValue("@ValorReal", liquidacion.ValorReal);
                command.Parameters.AddWithValue("@Nombre", liquidacion.Nombre);
                command.Parameters.AddWithValue("@Fecha", liquidacion.Fecha);
                command.Parameters.AddWithValue("@Tope", liquidacion.Tope);

                command.ExecuteNonQuery();               
            }
                
        }
        public IList<Liquidacion> Consultar()
        {
            lista = new List<Liquidacion>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from Liquidacion";
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Liquidacion liquidacion = DataReaderMapLiquidacion(dataReader);
                        lista.Add(liquidacion);
                    }
                }    
            }
            return lista;
        }

        private Liquidacion DataReaderMapLiquidacion(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;

            Liquidacion liquidacion = Liquidar(dataReader);

            liquidacion.NumeroLiquidacion = dataReader.GetString(0);
            liquidacion.Identificacion = dataReader.GetString(1);
            liquidacion.Salario = dataReader.GetInt32(2);
            liquidacion.Tarifa = dataReader.GetDouble(3);
            liquidacion.TipoAfiliacion = dataReader.GetString(4);
            liquidacion.ValorServicio = dataReader.GetInt32(5); 
            liquidacion.CuotaModerada = dataReader.GetDouble(6); 
            liquidacion.ValorReal = dataReader.GetDouble(7); 
            liquidacion.Nombre = dataReader.GetString(8); 
            liquidacion.Fecha = dataReader.GetDateTime(9); 
            liquidacion.Tope = dataReader.GetInt32(10);
            
            return liquidacion;
        }
        private static Liquidacion Liquidar(SqlDataReader dataReader)
        {
            Liquidacion liquidacion;
            if (dataReader.GetString(4).Equals("Contribuyente"))
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

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "DELETE from Liquidacion where NumeroLiquidacion = @NumeroLiquidacion";
                command.Parameters.AddWithValue("@NumeroLiquidacion", numeroLiquidacion);
                

                command.ExecuteNonQuery();
            }
        }

        public void Modificar(Liquidacion liquidacion)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE Liquidacion set Identificacion=@Identificacion, Salario=@Salario, Tarifa=@Tarifa,TipoAfiliacion=@TipoAfiliacion," +
                    "ValorServicio=@ValorServicio, CuotaModerada=@CuotaModerada, ValorReal=@ValorReal, Nombre=@Nombre, Fecha=@Fecha, " +
                    "Tope=@Tope";
                command.Parameters.AddWithValue("@NumeroLiquidacion", liquidacion.NumeroLiquidacion);
                command.Parameters.AddWithValue("@Identificacion", liquidacion.Identificacion);
                command.Parameters.AddWithValue("@Salario", liquidacion.Salario);
                command.Parameters.AddWithValue("@Tarifa", liquidacion.Tarifa);
                command.Parameters.AddWithValue("@TipoAfiliacion", liquidacion.TipoAfiliacion);
                command.Parameters.AddWithValue("@ValorServicio", liquidacion.ValorServicio);
                command.Parameters.AddWithValue("@CuotaModerada", liquidacion.CuotaModerada);
                command.Parameters.AddWithValue("@ValorReal", liquidacion.ValorReal);
                command.Parameters.AddWithValue("@Nombre", liquidacion.Nombre);
                command.Parameters.AddWithValue("@Fecha", liquidacion.Fecha);
                command.Parameters.AddWithValue("@Tope", liquidacion.Tope);
                command.ExecuteNonQuery();
            }
        }
        public void GuardarPorFiltro(IList<Liquidacion> liquidacions, string rutaFiltro)
        {
            StreamWriter escritor = new StreamWriter(rutaFiltro, false);

            foreach (var liquidacion in liquidacions)
            {
                escritor.WriteLine($"{liquidacion.Identificacion};{liquidacion.NumeroLiquidacion};{liquidacion.Salario};" +
                $"{liquidacion.Tarifa};{liquidacion.TipoAfiliacion};{liquidacion.ValorServicio};" +
                $"{liquidacion.CuotaModerada};{liquidacion.ValorReal};{liquidacion.Nombre};{liquidacion.Fecha}" +
                $";{liquidacion.Tope}");
            }
            escritor.Close();
        }
         public Liquidacion Buscar(string numeroLiquidacion)
        {
            lista = Consultar();

            return lista.Where(l => l.NumeroLiquidacion.Equals(numeroLiquidacion)).FirstOrDefault();
        }

        public IList<Liquidacion> FiltrarPorTipo(string tipo)
        {
            lista = Consultar();
            return lista.Where(l => l.TipoAfiliacion.Equals(tipo)).ToList();
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
