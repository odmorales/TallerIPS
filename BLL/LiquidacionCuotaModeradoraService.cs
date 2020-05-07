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
        

        public void GuardarRegimenContributivo(Liquidacion liquidacion)
        {
            liquidacionCuotaModeradoraRepository.Guardar(liquidacion);
        }

        public List<Liquidacion> ConsultarRegimenContributivo()
        {
            return liquidacionCuotaModeradoraRepository.Consultar();
        }
        public void Modificar(Liquidacion liquidacion)
        {
            liquidacionCuotaModeradoraRepository.Modificar(liquidacion);
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
        public LiquidacionCuotaModeradoraService()
        {
            liquidacionCuotaModeradoraRepository = new LiquidacionCuotaModeradoraRepository();
        }
    }
}
