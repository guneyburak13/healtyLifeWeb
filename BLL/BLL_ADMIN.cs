using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using DAL;

namespace BLL
{
    public class BLL_ADMIN
    {
        public string SaveAdmin(ent_ADMIN ent)
        {
            try
            {
                using (DataAccessEntities db = new DataAccessEntities())
                {
                    l_admin admin = new l_admin();
                    if (ent.adm_id != 0)
                        admin = db.l_admin.Where(p => p.adm_id == ent.adm_id).First();
                    admin.adm_ispassive = ent.adm_ispassive;
                    admin.adm_kullanici_adi = ent.adm_kullanici_adi;
                    admin.adm_name = ent.adm_name;
                    admin.adm_sifre = ent.adm_sifre;
                    if (ent.adm_id == 0)
                        db.l_admin.Add(admin);
                    db.SaveChanges();
                }
                return "success";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<ent_ADMIN> ListAdmin()
        {
            List<ent_ADMIN> result = new List<ent_ADMIN>();
            try
            {
                using (DataAccessEntities db = new DataAccessEntities())
                {
                    result = db.Database.SqlQuery<ent_ADMIN>("select * from l_admin").ToList();
                }
                return result;
            }

            catch (Exception)
            {

                return result;
            }
        }

        public ent_ADMIN SelectAdmin(int adm_id)
        {
            ent_ADMIN result = new ent_ADMIN();
            try
            {
                using (DataAccessEntities db=new DataAccessEntities())
                {
                    result = db.Database.SqlQuery<ent_ADMIN>("select * from l_admin as a where a.adm_id={0}",adm_id).First();
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
