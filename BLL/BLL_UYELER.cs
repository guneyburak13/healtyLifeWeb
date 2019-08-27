using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using DAL;
namespace BLL
{
    public class BLL_UYELER
    {
        public string SaveUyeler(ent_UYELER ent)
        {
            try
            {
                using (DataAccessEntities db=new DataAccessEntities())
                {
                    l_uyeler uyeler = new l_uyeler();
                    if (ent.uye_id != 0)
                        uyeler = db.l_uyeler.Where(p => p.uye_id == ent.uye_id).First();
                    uyeler.uye_ad_soyad = ent.uye_ad_soyad;
                    uyeler.uye_kullanici_adi = ent.uye_kullanici_adi;
                    uyeler.uye_sifre = ent.uye_sifre;
                    uyeler.uye_foto_url = ent.uye_foto_url;
                    uyeler.uye_detay = ent.uye_detay;
                    uyeler.uye_kayit_tarihi = ent.uye_kayit_tarihi;
                    uyeler.uye_telefon = ent.uye_telefon;
                    uyeler.uye_mail = ent.uye_mail;
                    uyeler.uye_ispassive = ent.uye_ispassive;
                    if (ent.uye_id == 0)
                        db.l_uyeler.Add(uyeler);
                    db.SaveChanges();
                }
                return "success";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<ent_UYELER> ListUyeler()
        {
            List<ent_UYELER> result = new List<ent_UYELER>();
            try
            {
                using (DataAccessEntities db = new DataAccessEntities())
                {
                    result = db.Database.SqlQuery<ent_UYELER>("select * from l_uyeler").ToList();
                }
                return result;
            }
            catch
            {
                return result;
            }
        }

        public ent_UYELER SelectUye(int uye_id)
        {
            ent_UYELER result = new ent_UYELER();
            try
            {
                using (DataAccessEntities db = new DataAccessEntities())
                {
                    result = db.Database.SqlQuery<ent_UYELER>("select * from l_uyeler as a where a.uye_id={0}", uye_id).First();
                }
                return result;
            }
            catch
            {
                return result;
            }
        }

    }
}
