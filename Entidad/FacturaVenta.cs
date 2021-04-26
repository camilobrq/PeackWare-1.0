using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class FacturaVenta: Factura
    {
        public FacturaVenta(Cliente cliente)
        {
           
            persona = cliente;
        }
    }
}
