using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL.Member
{
    public class DALLawsService
    {
        DAL.Member.LawsService objLawsService = new DAL.Member.LawsService();
        public List<LawsMaster> getLaws()
        {
            List<LawsMaster> Laws = new List<LawsMaster>();
            try
            {
                Laws = objLawsService.getLaws();
            }
            catch (Exception)
            {

            }
            return Laws;
        }
    }
}
