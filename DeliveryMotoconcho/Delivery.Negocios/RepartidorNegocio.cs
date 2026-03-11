using System.Collections.Generic;
using Delivery.Datos;

namespace Delivery.Negocios
{
    public class RepartidorNegocio
    {
        private RepartidorDAO dao = new RepartidorDAO();

        // Método normal
        public List<Repartidor> ObtenerTodos()
        {
            return dao.ObtenerTodos();
        }

        // Método como función — retorna valor calculado
        public List<Repartidor> ObtenerDisponibles()
        {
            return dao.ObtenerTodos().FindAll(r => r.Disponible == true);
        }

        public void Registrar(Repartidor r)
        {
            dao.Insertar(r);
        }
    }
}