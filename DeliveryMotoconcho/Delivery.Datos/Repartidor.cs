namespace Delivery.Datos
{
    public class Repartidor : EntidadBase
    {
        public Repartidor() : base() { }

        public int RepartidorID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public int ZonaID { get; set; }
        public bool Disponible { get; set; }

        public override string ObtenerDescripcion()
        {
            return $"Repartidor: {Nombre} - {(Disponible ? "Disponible" : "Ocupado")}";
        }

        public override string ObtenerInfo()
        {
            return base.ObtenerInfo() + $" | Tel: {Telefono}";
        }
    }
}