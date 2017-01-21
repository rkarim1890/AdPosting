using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Member
{
    public class DealsService
    {
        AdPosting_QRONYKEntities db = new AdPosting_QRONYKEntities();
        public List<DealsMaster> getDeals()
        {
            // var news = db.NewsMasters.Where(x => x.IsActive == true);

            List<DealsMaster> Deals = (from n in db.DealsMasters
                                     where n.IsActive == true
                                     select n).ToList();
            return Deals;
        }

        //public NewsMaster getNews(int NewsID)
        //{


        //    NewsMaster News = (from n in db.NewsMasters
        //                       where n.IsActive == true && n.NewsId == NewsID
        //                       select n).FirstOrDefault();


        //    return News;
        //}
        //public int updateLikes(int NewsID, string likeunlik)
        //{

        //    NewsMaster News = (from n in db.NewsMasters
        //                       where n.IsActive == true && n.NewsId == NewsID
        //                       select n).SingleOrDefault();
        //    if (likeunlik.ToUpper() == "LIKE")
        //        News.Likes = News.Likes + 1;
        //    else
        //        News.Likes = News.Likes - 1;
        //    if (News.Likes < 0)
        //        News.Likes = 0;
        //    db.SaveChanges();
        //    return (int)News.Likes;
        //}
        //public int AddComments(Comments_News_Master Comment)
        //{
        //    try
        //    {


        //        db.Comments_News_Master.Add(Comment);


        //        db.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    return 0;
        //}
    }
}
