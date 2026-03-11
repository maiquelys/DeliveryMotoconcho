using System.Collections.Generic;
using Delivery.Datos;

namespace Delivery.Negocios
{
    public class PedidoNegocio
    {
        private PedidoDAO dao = new PedidoDAO();
        private RepartidorDAO repartidorDAO = new RepartidorDAO();

        public List<Pedido> ObtenerTodos()
        {
            return dao.ObtenerTodos();
        }

        // Regla de negocio: solo asignar si el repartidor está disponible
        public string RegistrarPedido(Pedido p)
        {
            List<Repartidor> disponibles = repartidorDAO.ObtenerTodos()
                .FindAll(r => r.ZonaID == p.ZonaID && r.Disponible == true);

            if (disponibles.Count == 0)
                return "No hay repartidores disponibles en esa zona.";

            dao.Insertar(p);
            return "Pedido registrado correctamente.";
        }
    }
}
