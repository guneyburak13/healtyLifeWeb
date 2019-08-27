using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using DAL;
namespace BLL
{
    public class BLL_KATEGORI
    {
        public string SaveKategori(ent_KATEGORI ent)
        {
            try
            {
                using (DataAccessEntities db=new DataAccessEntities())
                {
                    l_kategori kategori = new l_kategori();
                    if (ent.kategori_id != 0)
                        kategori = db.l_kategori.Where(p => p.kategori_id == ent.kategori_id).First();
                    kategori.kategori_ad = ent.kategori_ad;
                    if (ent.kategori_id == 0)
                        db.l_kategori.Add(kategori);
                    db.SaveChanges();
                }
                return "success";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<ent_KATEGORI> ListKategori()
        {
            List<ent_KATEGORI> result = new List<ent_KATEGORI>();
            try
            {
                using (DataAccessEntities db = new DataAccessEntities())
                {
                    result = db.Database.SqlQuery<ent_KATEGORI>("select * from l_kategori").ToList();
                }
                return result;
            }
            catch
            {
                return result;
            }
        }

        public ent_KATEGORI SelectKategori(int ktgr_id)
        {
            ent_KATEGORI result = new ent_KATEGORI();
            try
            {
                using (DataAccessEntities db = new DataAccessEntities())
                {
                    result = db.Database.SqlQuery<ent_KATEGORI>("select * from l_kategori as a where a.kategori_id={0}", ktgr_id).First();
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
