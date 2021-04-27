using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Factura
    {
        DetalleFactura detalleFactura = new DetalleFactura();
        public string IdFactura { get; set; }
        public string IdPersona { get; set; }
        public Persona persona { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleFactura> DetalleFacturas { get; set; }
        public decimal Subtotal { get; set; }
       
        public decimal Total { get; set; }

        public decimal CalcularSubtotal()
        {
           
           return Subtotal = detalleFactura.CalcularImporte();
        }

        public decimal CalcularTotal()
        {
            if (detalleFactura.CalcularDescuento()>0)
            {
                return Total = (CalcularSubtotal() - detalleFactura.CalcularDescuento()) + detalleFactura.CalculaIva();
            }
            else
            {
                return Total = (CalcularSubtotal()  + detalleFactura.CalculaIva());
            }
        }
    }
}
