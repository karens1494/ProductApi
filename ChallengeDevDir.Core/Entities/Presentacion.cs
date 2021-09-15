using System;
using System.Collections.Generic;

namespace ChallengeDevDir.Core.Entities
{
    public partial class Presentacion
    {
        public Presentacion()
        {
            Producto = new HashSet<Producto>();
        }

        public int IdPresentacion { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
