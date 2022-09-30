using System;
using System.Collections.Generic;

#nullable disable

namespace Cozum.Rapor.Entities
{
    public partial class RprDirectory
    {
        public int? PersonelNo { get; set; }
        public string Num { get; set; }
        public string Tur { get; set; }
        public string Varsayilan { get; set; }
        public string Sube { get; set; }
        public DateTime? Ctimestamp { get; set; }
    }
}
