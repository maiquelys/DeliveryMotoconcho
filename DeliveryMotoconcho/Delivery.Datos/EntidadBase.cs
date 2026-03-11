using System;

namespace Delivery.Datos
{
    public abstract class EntidadBase
    {
        // Constructor
        public EntidadBase()
        {
            FechaCreacion = DateTime.Now;
        }

        public DateTime FechaCreacion { get; set; }

        // Método abstracto — cada clase hija DEBE implementarlo
        public abstract string ObtenerDescripcion();

        // Método virtual — puede ser sobreescrito o no
        public virtual string ObtenerInfo()
        {
            return $"Creado el: {FechaCreacion:dd/MM/yyyy}";
        }
    }
}
