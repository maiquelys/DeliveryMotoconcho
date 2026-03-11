namespace Delivery.Datos
{
    public class Zona : EntidadBase
    {
        public Zona() : base() { }

        public int ZonaID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public override string ObtenerDescripcion()
        {
            return $"Zona: {Nombre}";
        }
    }
}
