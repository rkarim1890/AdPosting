using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Member
{
    public class TrendingService
    {
        AdPosting_QRONYKEntities db = new AdPosting_QRONYKEntities();
        public List<TreadingMaster> getTrendings()
        {
            List<TreadingMaster> Trendings = (from n in db.TreadingMasters
                                              where n.IsActive == true
                                              select n).ToList();
            return Trendings;
        }
    }
}
