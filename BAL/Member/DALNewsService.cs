using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Member
{
    public class DALNewsService
    {
        DAL.Member.NewsService objNewsService = new DAL.Member.NewsService();
        public List<NewsMaster> getNews()
        {

            List<NewsMaster> news = new List<NewsMaster>();
            try
            {
                return objNewsService.getNews(); ;
            }
            catch (Exception)
            {

                throw;
            }

            return news;
        }
        public NewsMaster getNews(int NewsID)
        {

            NewsMaster news = new NewsMaster();
            try
            {
                return objNewsService.getNews(NewsID); ;
            }
            catch (Exception)
            {

                throw;
            }

            return news;
        }
        public int updateLikes(int NewsID, string likeunlik)
        {


            try
            {
                return objNewsService.updateLikes(NewsID, likeunlik); ;
            }
            catch (Exception)
            {

                throw;
            }

            return 0;
        }

        public int AddComments(int NewsID, string Comment,string userName)
        {


            try
            {
                Comments_News_Master objComments_News_Master = new Comments_News_Master();
                objComments_News_Master.Comment = Comment;
                objComments_News_Master.CreatedBy = userName;
                objComments_News_Master.NewsID = NewsID;
                objComments_News_Master.CreatedDate = DateTime.Now;



                return objNewsService.AddComments(objComments_News_Master); ;
            }
            catch (Exception)
            {

                throw;
            }

            return 0;
        }

    }
}
