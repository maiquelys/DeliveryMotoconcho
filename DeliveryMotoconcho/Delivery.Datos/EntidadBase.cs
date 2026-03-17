using System;

namespace Delivery.Datos
{
    public abstract class EntidadBase
    {
        // contructor
        public EntidadBase()
        {
            FechaCreacion = DateTime.Now;
        }

        public DateTime FechaCreacion { get; set; }

        // metodo abstracto
        public abstract string ObtenerDescripcion();

        // metodo virtual
        public virtual string ObtenerInfo()
        {
            return $"Creado el: {FechaCreacion:dd/MM/yyyy}";
        }
    }
}
