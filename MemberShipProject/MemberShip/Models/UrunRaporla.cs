using System;
using System.Collections.Generic;

namespace MemberShip.Models
{
    public partial class UrunRaporla
    {
        public string UrunAdi { get; set; }
        public string BirimdekiMiktar { get; set; }
        public Nullable<decimal> BirimFiyati { get; set; }
        public string KategoriAdi { get; set; }
        public string SirketAdi { get; set; }
    }
}
