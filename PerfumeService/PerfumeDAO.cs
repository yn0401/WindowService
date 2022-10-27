using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using PerfumeShared;

namespace PerfumeService
{
        public class PerfumeDAO
        {
            MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strPerfume"].ConnectionString);

            public List<Perfume> SelectAll()
            {
                db.ObjectTrackingEnabled = false;

                List<Perfume> per = db.Perfumes.ToList();
                return per;
            }


            public Perfume SelectByCode(int Id)
            {
            db.ObjectTrackingEnabled = false;
            Perfume p = db.Perfumes.SingleOrDefault(b => b.Id == Id);
                return p;
            }

            public List<Perfume> SelectByKeyword(string keyword)
            {
            db.ObjectTrackingEnabled = false;
            List<Perfume> per = db.Perfumes.Where(b => b.Name.Contains(keyword)).ToList();
                return per;
            }

            public bool Insert(Perfume newPerfume)
            {
                try
                {
                    db.Perfumes.InsertOnSubmit(newPerfume);
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }

            public bool Update(Perfume newPerfume)
            {
                Perfume dbPerfume = db.Perfumes.SingleOrDefault(b => b.Id == newPerfume.Id);
                if (dbPerfume != null)
                {
                    try
                    {
                        dbPerfume.Name = newPerfume.Name;
                        dbPerfume.Brand = newPerfume.Brand;
                        dbPerfume.Origin = newPerfume.Origin;
                        dbPerfume.Price = newPerfume.Price;
                        db.SubmitChanges();
                        return true;
                    }
                    catch { return false; }
                }
                return false;
            }

            public bool Delete(int Id)
            {
                Perfume dbPerfume = db.Perfumes.SingleOrDefault(b => b.Id == Id);
                if (dbPerfume != null)
                {
                    try
                    {
                        db.Perfumes.DeleteOnSubmit(dbPerfume);
                        db.SubmitChanges();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
                return false;
            }
        }
    }
