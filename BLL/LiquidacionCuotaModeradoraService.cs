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
        Liquidacion liquidacion;
        

        public string Guardar(Liquidacion liquidacion)
        {
           
                liquidacionCuotaModeradoraRepository.Guardar(liquidacion);
                return "Guardado Correctamente";
          
        }

        public IList<Liquidacion> Consultar()
        {
            return liquidacionCuotaModeradoraRepository.Consultar();
        }
        public string Modificar(Liquidacion liquidacion)
        {
            liquidacionCuotaModeradoraRepository.Modificar(liquidacion);

            return $"La liquidacion con el numero{liquidacion.NumeroLiquidacion} ha sido modificado";
        }

        public string Eliminar(string numeroLiquidacion)
        {
            liquidacionCuotaModeradoraRepository.Eliminar(numeroLiquidacion);

            return "Eliminado";
        }
        public Liquidacion Buscar(string numeroLiquidacion)
        {
            liquidacion = liquidacionCuotaModeradoraRepository.Buscar(numeroLiquidacion);

            if (liquidacion != null)
            {
                return liquidacion;
            }

            return null;
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
}
