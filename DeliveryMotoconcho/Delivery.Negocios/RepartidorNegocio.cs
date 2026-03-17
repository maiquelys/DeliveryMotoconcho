using System.Collections.Generic;
using Delivery.Datos;

namespace Delivery.Negocios
{
    public class RepartidorNegocio
    {
        private RepartidorDAO dao = new RepartidorDAO();

        // metodo normal
        public List<Repartidor> ObtenerTodos()
        {
            return dao.ObtenerTodos();
        }

        // metodo como funcion 
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