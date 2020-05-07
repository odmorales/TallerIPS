using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class LiquidacionCuotaModeradoraService
    {

        LiquidacionCuotaModeradoraRepository liquidacionCuotaModeradoraRepository;
        
        

        public string Guardar(Liquidacion liquidacion)
        {
            try
            {
                liquidacionCuotaModeradoraRepository.Guardar(liquidacion);
                return "Guardado Correctamente";
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
            }
                       
          
        }

        public RespuestaConsulta Consultar()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {
                respuesta.Error = false;
                respuesta.Lista = liquidacionCuotaModeradoraRepository.Consultar();
                if(respuesta.Lista != null)
                {
                    respuesta.Mensaje = "Datos consultados correctamente";
                }
                else
                {
                    respuesta.Mensaje = "No existen los datos consultados";
                }
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = $"Error, la consulta ha fallado: {e.Message}";
                respuesta.Lista = null;
                return respuesta;
            }
            
        }
        public string Modificar(Liquidacion liquidacion)
        {
            try
            {
                liquidacionCuotaModeradoraRepository.Modificar(liquidacion);
                return $"La liquidacion con el numero{liquidacion.NumeroLiquidacion} ha sido modificado";
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
            }
            
        }

        public string Eliminar(string numeroLiquidacion)
        {
            try
            {
                liquidacionCuotaModeradoraRepository.Eliminar(numeroLiquidacion);
                return "Eliminado";
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
            }
            
        }
        public RespuestaBuscar Buscar(string numeroLiquidacion)
        {
            RespuestaBuscar respuesta = new RespuestaBuscar();
            try
            {
                respuesta.liquidacion = liquidacionCuotaModeradoraRepository.Buscar(numeroLiquidacion);
                if(respuesta.liquidacion != null)
                {
                    respuesta.Mensaje = "Liquidacion encontrada";
                }
                else
                {
                    respuesta.Mensaje = "Liquidacion no encontrada";
                }
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.liquidacion = null;
                respuesta.Mensaje = $"Error: {e.Message}";
                return respuesta;
            }
        }
        public IList<Liquidacion> FiltrarPorTipo(string tipo)
        {
            return liquidacionCuotaModeradoraRepository.FiltrarPorTipo(tipo);
        }
        public int TotalporLiquidacion(string tipo)
        {
            return liquidacionCuotaModeradoraRepository.TotalPorLiquidacion(tipo);
        }
        public int TotalLiquidacionTodos()
        {
            return liquidacionCuotaModeradoraRepository.TotalLiquidacionTodos();
        }
        public double TotalCuotaModeradora(string tipo)
        {
            return liquidacionCuotaModeradoraRepository.TotalCuotaModeradora(tipo);
        }
        public IList<Liquidacion> FiltrarPorFecha(int Mes, int Anio)
        {
            return liquidacionCuotaModeradoraRepository.FiltrarPorFecha(Mes, Anio);
        }
        public IList<Liquidacion> ConsultarPorPalabra(string palabra)
        {
            
            return liquidacionCuotaModeradoraRepository.ConsultarPorPalabra(palabra);
        }
        public double TotalCuotaModeradoraTodos()
        {    
            return liquidacionCuotaModeradoraRepository.TotalCuotaModeradoraTodos();
        }
        public LiquidacionCuotaModeradoraService()
        {
            liquidacionCuotaModeradoraRepository = new LiquidacionCuotaModeradoraRepository();
        }
    }
    public class RespuestaConsulta
    {
        public string Mensaje { get; set; }
        public IList<Liquidacion> Lista { get; set; }
        public bool Error { get; set; }
    }
    public class RespuestaBuscar
    {
        public string Mensaje { get; set; }
        public Liquidacion liquidacion { get; set; }
    }
}
