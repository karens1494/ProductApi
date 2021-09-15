using System;
using System.Collections.Generic;

namespace ChallengeDevDir.Core.Entities
{
    public partial class Zona
    {
        public Zona()
        {
            Producto = new HashSet<Producto>();
        }

        public int IdZona { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
