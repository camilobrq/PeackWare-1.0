using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Factura
    {
        public Producto producto { get; set; }
        DetalleFactura detalleFactura = new DetalleFactura();
  
  
        public string IdFactura { get; set; }
        public string IdPersona { get; set; }
        public Persona persona { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleFactura> DetalleFacturas { get; set; }
        public decimal Subtotal { get; set; }
       
        public decimal Total { get; set; }

        public void CalcularSubtotal()
        {
            detalleFactura.CalcularImporte();
            Subtotal = detalleFactura.Importe;
        }

        public void CalcularTotal()
        {
           CalcularSubtotal();
           detalleFactura.CalcularDescuento();
           detalleFactura.CalculaIva();
           Total = (Subtotal -detalleFactura.Descuento) + detalleFactura.Iva;
         
        }
    }
}
