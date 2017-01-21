using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Member
{
    public class LawsService
    {
        AdPosting_QRONYKEntities db = new AdPosting_QRONYKEntities();
        public List<LawsMaster> getLaws()
        {          
            List<LawsMaster> Laws = (from n in db.LawsMasters
                                     where n.IsActive == true
                                     select n).ToList();
            return Laws;
        }
    }
}
