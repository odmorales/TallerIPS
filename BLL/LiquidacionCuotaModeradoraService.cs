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

        public void GuardarRegimenContributivo(Liquidacion liquidacion)
        {
            liquidacionCuotaModeradoraRepository.GuardarRegimenContributivo(liquidacion);
        }

        public void ModificarRegimenContributivo(Liquidacion liquidacion)
        {
            liquidacionCuotaModeradoraRepository.ModificarRegimenContributivo(liquidacion);
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
        public LiquidacionCuotaModeradoraService()
        {
            liquidacionCuotaModeradoraRepository = new LiquidacionCuotaModeradoraRepository();
        }
    }
}
