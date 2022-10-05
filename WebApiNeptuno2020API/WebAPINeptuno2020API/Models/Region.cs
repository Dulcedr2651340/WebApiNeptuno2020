using System;
using System.Collections.Generic;

namespace WebAPINeptuno2020API.Models
{
    public partial class Region
    {
        public Region()
        {
            Territorios = new HashSet<Territorios>();
        }

        public int IdRegion { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Territorios> Territorios { get; set; }
    }
}
