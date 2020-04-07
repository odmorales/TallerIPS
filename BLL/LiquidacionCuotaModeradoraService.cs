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
        Liquidacion liquidacion = new LiquidacionRegimenContributivo();
        Liquidacion liquidacion1 = new LiquidacionRegimenSubsidiado();

        public void GuardarRegimenContributivo(Liquidacion liquidacion)
        {
            liquidacionCuotaModeradoraRepository.GuardarRegimenContributivo(liquidacion);
        }

        public List<LiquidacionRegimenContributivo> ConsultarRegimenContributivo()
        {
            return liquidacionCuotaModeradoraRepository.ConsultarRegimenContributivo();
        }
        public void ModificarRegimenContributivo(Liquidacion liquidacion)
        {
            liquidacionCuotaModeradoraRepository.ModificarRegimenContributivo(liquidacion);
        }

        public string EliminarRegimenContributivo(string numeroLiquidacion)
        {
            liquidacionCuotaModeradoraRepository.EliminarRegimenContributivo(numeroLiquidacion);

            return "Eliminado";
        }
        public Liquidacion BuscarRegimenContributivo(string numeroLiquidacion)
        {
            liquidacion = liquidacionCuotaModeradoraRepository.Buscar(numeroLiquidacion);

            if (liquidacion != null)
            {
                return liquidacion;
            }

            return null;
        }

        public void GuardarRegimenSubsidiado(Liquidacion liquidacion1)
        {
            liquidacionCuotaModeradoraRepository.GuardarRegimenSubsidiado(liquidacion1);
        }
        public List<LiquidacionRegimenSubsidiado> ConsultarRegimenSubsidiado()
        {
            return liquidacionCuotaModeradoraRepository.ConsultarRegimenSubsidiado();
        }
        public void ModificarRegimenSubsidiado(Liquidacion liquidacion1)
        {
            liquidacionCuotaModeradoraRepository.ModificarRegimenContributivo(liquidacion1);
        }

        public string EliminarRegimenSubsidiado(string numeroLiquidacion)
        {
            liquidacionCuotaModeradoraRepository.EliminarRegimenSubsidiado(numeroLiquidacion);

            return "Eliminado";
        }
        public Liquidacion BuscarRegimenSubsidiado(string numeroLiquidacion)
        {
            liquidacion1 = liquidacionCuotaModeradoraRepository.BuscarSubsidiado(numeroLiquidacion);

            if (liquidacion != null)
            {
                return liquidacion1;
            }

            return null;
        }
        public LiquidacionCuotaModeradoraService()
        {
            liquidacionCuotaModeradoraRepository = new LiquidacionCuotaModeradoraRepository();
        }
    }
}
