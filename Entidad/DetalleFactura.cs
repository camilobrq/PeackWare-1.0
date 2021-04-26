using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DetalleFactura
    {
        public string Idproducto { get; set; }
        public string Descripcion { get; set; }
        public Producto producto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal Importe { get; set; }
        public decimal Iva { get; set; }
        public decimal Descuento { get; set; }
        decimal porcentajeIva = 1.19m;
       public decimal CalcularImporte()
        {
            return Importe = PrecioUnitario *Cantidad;
        }

        public decimal CalculaIva()
        {
            return Iva=(PrecioUnitario *Cantidad) * porcentajeIva;
        }
        public decimal CalcularDescuento()
        {
            if (producto.Descuento>0)
            {
                return Descuento = (CalculaIva() * producto.Descuento);
            }
            return 0;
        }
    }
}
