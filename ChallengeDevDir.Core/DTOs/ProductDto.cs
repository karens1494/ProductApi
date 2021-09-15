using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeDevDir.Core.DTOs
{
    public class ProductDto
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
    }
}
