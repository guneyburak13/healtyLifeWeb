using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ent_URUNLER
    {
        public int urun_id { get; set; }
        public string urun_adi { get; set; }
        public Nullable<int> urun_kategori_id { get; set; }
        public Nullable<int> urun_uye_id { get; set; }
        public int urun_fiyat { get; set; }
        public string urun_detay { get; set; }
        public string urun_foto_url { get; set; }
        public bool urun_ispassive { get; set; }
        public Nullable<System.DateTime> urun_tarih { get; set; }
        public string urun_kategori_adi { get; set; }

        public string urun_uye_adi { get; set; }
    }
}
