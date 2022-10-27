using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClient
{
    public class PerfumeBUS
    {
        public List<Perfume> GetAll()
        {
            List<Perfume> per = new PerfumeDAO().SelectAll();
            return per;
        }
        public Perfume GetDetails(int Id)
        {
            Perfume p = new PerfumeDAO().SelectByCode(Id);
            return p;
        }
        public List<Perfume> Search(string keyword)
        {
            List<Perfume> per = new PerfumeDAO().SelectByKeyword(keyword);
            return per;
        }
        public bool AddNew(Perfume newPerfume)
        {
            bool result = new PerfumeDAO().Insert(newPerfume);
            return result;
        }
        public bool Update(Perfume newPerfume)
        {
            bool result = new PerfumeDAO().Update(newPerfume);
            return result;
        }
        public bool Delete(int Id)
        {
            bool result = new PerfumeDAO().Delete(Id);
            return result;
        }
    }
}
