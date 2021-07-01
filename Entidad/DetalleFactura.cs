using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DetalleFactura
    {
        public string IdProducto { get; set; }
        public Producto producto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string Descripcion { get; set; }
        public decimal Importe { get; set; }
        public decimal Iva { get; set; }
        public decimal Descuento { get; set; }
        decimal porcentajeIva = 1.19m;
       public void CalcularImporte()
        {
            Importe = producto.PrecioUnidad *producto.Cantidad;
        }

        public void CalculaIva()
        {
            CalcularImporte();
            CalcularDescuento();
             Iva=(Importe-Descuento) * porcentajeIva;
        }
        public void CalcularDescuento()
        {
            Descuento = 0;
            CalcularImporte();
            if (producto.Descuento>0)
            {
            
                 Descuento = (Importe * producto.Descuento);
            }
           
        }
    }
}
