using System.Collections.Generic;
using Delivery.Datos;

namespace Delivery.Negocios
{
    public class LiquidacionNegocio
    {
        private LiquidacionDAO dao = new LiquidacionDAO();

        public List<LiquidacionDiaria> ObtenerTodos()
        {
            return dao.ObtenerTodos();
        }

        public void Registrar(LiquidacionDiaria l)
        {
            dao.Insertar(l);
        }

        // Regla de negocio: liquidación cerrada no se puede editar
        public string CerrarLiquidacion(int liquidacionID)
        {
            List<LiquidacionDiaria> lista = dao.ObtenerTodos();
            LiquidacionDiaria liq = lista.Find(l => l.LiquidacionID == liquidacionID);

            if (liq == null)
                return "Liquidación no encontrada.";

            if (liq.Cerrada)
                return "Esta liquidación ya está cerrada y no puede modificarse.";

            dao.CerrarLiquidacion(liquidacionID);
            return "Liquidación cerrada exitosamente.";
        }
    }
}