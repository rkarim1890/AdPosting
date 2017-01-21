using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL.Member
{
    public class DALDealsService
    {
        DAL.Member.DealsService objDealsService = new DAL.Member.DealsService();
        public List<DealsMaster> getDeals()
        {

            List<DealsMaster> Deals = new List<DealsMaster>();
            try
            {
                return objDealsService.getDeals(); ;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //public DealsMaster getNews(int NewsID)
        //{

        //    DealsMaster news = new DealsMaster();
        //    try
        //    {
        //        return objDealsService.getNews(NewsID); ;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    return news;
        //}
        //public int updateLikes(int NewsID, string likeunlik)
        //{


        //    try
        //    {
        //        return objDealsService.updateLikes(NewsID, likeunlik); ;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    return 0;
        //}
        //public int AddComments(int NewsID, string Comment, string userName)
        //{


        //    try
        //    {
        //        Comments_News_Master objComments_News_Master = new Comments_News_Master();
        //        objComments_News_Master.Comment = Comment;
        //        objComments_News_Master.CreatedBy = userName;
        //        objComments_News_Master.NewsID = NewsID;
        //        objComments_News_Master.CreatedDate = DateTime.Now;



        //        return objDealsService.AddComments(objComments_News_Master); ;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    return 0;
        //}
    }
}
