using System;
using System.Collections.Generic;

namespace ChallengeDevDir.Core.Entities
{
    public partial class Producto
    {
        public int IdProducto { get; set; }
        public int? IdMarca { get; set; }
        public int? IdPresentacion { get; set; }
        public int? IdProveedor { get; set; }
        public int? IdZona { get; set; }
        public int? Codigo { get; set; }
        public string DescripcionProducto { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int? Iva { get; set; }
        public double? Peso { get; set; }

        public virtual Marca Marca { get; set; }
        public virtual Presentacion Presentacion { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual Zona Zona { get; set; }
    }
}
