using System;

namespace PharmacyStockTracking
{
    public class Ilac
    {
        public int IlacId { get; set; }
        public string IlacAdi { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
        public long BarkodNo { get; set; }
        public double Fiyati { get; set; }
        public int Adedi { get; set; }
    }
}