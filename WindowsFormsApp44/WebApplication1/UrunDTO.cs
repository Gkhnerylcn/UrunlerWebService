using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class UrunDTO
    {
        public int Urunid { get; set; }
        public string UrunAd { get; set; }
        public Nullable<short> UrunKategori { get; set; }
        public Nullable<decimal> UrunFiyat { get; set; }
        public string Marka { get; set; }
        public Nullable<byte> Stok { get; set; }

    }
}