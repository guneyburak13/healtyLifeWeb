//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class l_urunler
    {
        public int urun_id { get; set; }
        public string urun_adi { get; set; }
        public Nullable<int> urun_kategori_id { get; set; }
        public Nullable<int> urun_fiyat { get; set; }
        public string urun_detay { get; set; }
        public string urun_foto_url { get; set; }
        public Nullable<int> urun_uye_id { get; set; }
        public Nullable<System.DateTime> urun_tarih { get; set; }
        public bool urun_ispassive { get; set; }
    }
}
