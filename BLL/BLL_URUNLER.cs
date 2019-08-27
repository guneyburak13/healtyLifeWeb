using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using DAL;

namespace BLL
{
    public class BLL_URUNLER
    {
        public string SaveUrun(ent_URUNLER ent)
        {
            try
            {
                using (DataAccessEntities db=new DataAccessEntities())
                {
                    l_urunler urun = new l_urunler();
                    if (ent.urun_id != 0)
                        urun = db.l_urunler.Where(p => p.urun_id == ent.urun_id).First();
                    urun.urun_adi = ent.urun_adi;
                    urun.urun_kategori_id = ent.urun_kategori_id;
                    urun.urun_fiyat = ent.urun_fiyat;
                    urun.urun_detay = ent.urun_detay.ToString();
                    urun.urun_foto_url = ent.urun_foto_url;
                    urun.urun_uye_id = ent.urun_uye_id;
                    urun.urun_tarih = ent.urun_tarih;
                    urun.urun_ispassive = ent.urun_ispassive;
                    if (ent.urun_id==0)
                        db.l_urunler.Add(urun);
                    db.SaveChanges();
                
                }
                return "success";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<ent_URUNLER> ListUrun()
        {

            List<ent_URUNLER> result = new List<ent_URUNLER>();
            try
            {

                using (DataAccessEntities db = new DataAccessEntities())
                {
                    result = db.Database.SqlQuery<ent_URUNLER>("SELECT kat.kategori_ad as urun_kategori_adi, uye.uye_ad_soyad as urun_uye_adi, urun.urun_detay,urun.urun_foto_url, urun.urun_tarih, urun.urun_adi,urun.* FROM l_urunler as urun LEFT JOIN l_kategori as kat ON urun.urun_kategori_id = kat.kategori_id LEFT JOIN   l_uyeler as uye ON uye.uye_id = urun.urun_uye_id").ToList();
                   
                }
                return result;
            }
            catch
            {
                return result;
            }
        }

        public ent_URUNLER UrunGoruntule(int urun_id)
        {

            ent_URUNLER result = new ent_URUNLER();
            try
            {
                using (DataAccessEntities db=new DataAccessEntities())
                {
                    result = db.Database.SqlQuery<ent_URUNLER>("select urun.urun_adi,kat.kategori_ad as urun_kategori_adi, uye.uye_ad_soyad as urun_uye_adi,urun.urun_detay,urun.urun_foto_url,urun.urun_tarih,urun.urun_fiyat,urun.* FROM l_urunler as urun LEFT JOIN l_kategori as kat ON urun.urun_kategori_id = kat.kategori_id LEFT JOIN   l_uyeler as uye ON uye.uye_id = urun.urun_uye_id where urun.urun_id={0}", urun_id).First();
                }
                return result;
            }
            catch (Exception)
            {

               return result ;
            }
        }

        public List<ent_URUNLER> UrunListele_By_Ktgid(int ktg_id)
        {
            List<ent_URUNLER> result = new List<ent_URUNLER>();
            try
            {
                using (DataAccessEntities db=new DataAccessEntities())
                {
                    result = db.Database.SqlQuery<ent_URUNLER>("SELECT urun.urun_adi,kat.kategori_ad as urun_kategori_adi, uye.uye_ad_soyad as urun_uye_adi,urun.urun_detay,urun.urun_foto_url,urun.urun_tarih,urun.* FROM l_urunler as urun LEFT JOIN l_kategori as kat ON urun.urun_kategori_id = kat.kategori_id LEFT JOIN   l_uyeler as uye ON uye.uye_id = urun.urun_uye_id where urun.urun_kategori_id={0} order by urun.urun_tarih desc", ktg_id).ToList();
                }
                return result;
            }
            catch (Exception)
            {

                return result;
            }
        }

        public ent_URUNLER SelectUrun(int urun_id)
        {
            ent_URUNLER result = new ent_URUNLER();
            try
            {
                using (DataAccessEntities db = new DataAccessEntities())
                {
                    result = db.Database.SqlQuery<ent_URUNLER>("select * from l_urunler as urun where urun.urun_id={0}",urun_id).First();
                }
                return result;
            }
            catch 
            {

                return result;
            }
        }

        public ent_URUNLER SonBitkiselUrun()
        {
            ent_URUNLER result = new ent_URUNLER();
            try
            {
                using (DataAccessEntities db = new DataAccessEntities())
                {
                    result = db.Database.SqlQuery<ent_URUNLER>("select TOP 1 * from l_urunler where l_urunler.urun_kategori_id = 1 order by l_urunler.urun_tarih desc ").First();
                }
                return result;
            }
            catch
            {

                return result;
            }
        }
        public ent_URUNLER SonZayıflamaUrun()
        {
            ent_URUNLER result = new ent_URUNLER();
            try
            {
                using (DataAccessEntities db = new DataAccessEntities())
                {
                    result = db.Database.SqlQuery<ent_URUNLER>("select TOP 1 * from l_urunler where l_urunler.urun_kategori_id = 2 order by l_urunler.urun_tarih desc ").First();
                }
                return result;
            }
            catch
            {

                return result;
            }
        }
        public ent_URUNLER SonSporUrun()
        {
            ent_URUNLER result = new ent_URUNLER();
            try
            {
                using (DataAccessEntities db = new DataAccessEntities())
                {
                    result = db.Database.SqlQuery<ent_URUNLER>("select TOP 1 * from l_urunler where l_urunler.urun_kategori_id = 3 order by l_urunler.urun_tarih desc ").First();
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
