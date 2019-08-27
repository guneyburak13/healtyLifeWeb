using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ent_UYELER
    {
        public int uye_id { get; set; }
        public string uye_ad_soyad { get; set; }
        public string uye_kullanici_adi { get; set; }
        public string uye_foto_url { get; set; }
        public string uye_detay { get; set; }
        public Nullable<System.DateTime> uye_kayit_tarihi { get; set; }
        public string uye_telefon { get; set; }
        public string uye_mail { get; set; }
        public bool uye_ispassive { get; set; }
        public string uye_sifre { get; set; }

    }
}
