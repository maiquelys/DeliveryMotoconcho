using System;

namespace Delivery.Datos
{
    public class LiquidacionDiaria : EntidadBase
    {
        public LiquidacionDiaria() : base() { }

        public int LiquidacionID { get; set; }
        public int RepartidorID { get; set; }
        public DateTime Fecha { get; set; }
        public int TotalEntregas { get; set; }
        public decimal TotalGanado { get; set; }
        public bool Cerrada { get; set; }

        public override string ObtenerDescripcion()
        {
            return $"Liquidación {Fecha:dd/MM/yyyy} - {(Cerrada ? "CERRADA" : "Abierta")}";
        }
    }
}