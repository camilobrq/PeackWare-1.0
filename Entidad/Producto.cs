﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Producto
    {
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioUnidad { get; set; }
        public int Cantidad { get; set; }
        public decimal Descuento { get; set; }
        public string Descripcion { get; set; }
        public decimal porcentajeIva = 1.19m;
    }
}
