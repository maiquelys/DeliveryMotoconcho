using System;

namespace Delivery.Datos
{
    public class Pedido : EntidadBase
    {
        public Pedido() : base() { }

        public int PedidoID { get; set; }
        public int RepartidorID { get; set; }
        public int ZonaID { get; set; }
        public DateTime FechaPedido { get; set; }
        public string DireccionEntrega { get; set; }
        public string Estado { get; set; }

        public override string ObtenerDescripcion()
        {
            return $"Pedido #{PedidoID} - {Estado}";
        }
    }
}