using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeShared
{
    public interface IPerfumeBUS
    {
        List<Perfume> GetAll();
        Perfume GetDetails(int Id);
        List<Perfume> Search(String keyword);
        bool AddNew(Perfume newPerfume);
        bool Update(Perfume newPerfume);
        bool Delete(int Id);
    }
}
