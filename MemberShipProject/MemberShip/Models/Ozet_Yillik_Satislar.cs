using System;
using System.Collections.Generic;

namespace MemberShip.Models
{
    public partial class Ozet_Yillik_Satislar
    {
        public Nullable<System.DateTime> SevkTarihi { get; set; }
        public int SatisID { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
    }
}
