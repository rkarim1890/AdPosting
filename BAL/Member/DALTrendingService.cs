using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BAL.Member
{
    public class DALTrendingService
    {
        DAL.Member.TrendingService objTrendingService = new DAL.Member.TrendingService();
        public List<TreadingMaster> getTrendings()
        {
            List<TreadingMaster> Trendings = new List<TreadingMaster>();
            try
            {
                Trendings = objTrendingService.getTrendings(); ;
            }
            catch (Exception)
            {

            }
            return Trendings;
        }
    }
}
