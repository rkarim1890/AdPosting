
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Member
{
    public class NewsService
    {
        AdPosting_QRONYKEntities db = new AdPosting_QRONYKEntities();
        public List<NewsMaster> getNews()
        {
            // var news = db.NewsMasters.Where(x => x.IsActive == true);

            List<NewsMaster> News = (from n in db.NewsMasters
                                     where n.IsActive == true
                                     select n).ToList();
            //select new NewsMaster
            //{
            //    NewsId = n.NewsId,
            //    Title = n.Title,
            //    ImagePath = n.ImagePath,
            //    Description = n.Description,
            //    IsActive = n.IsActive,
            //    Likes = n.Likes,
            //    Location_Name = n.Location_Name,
            //    CreatedBy = n.CreatedBy,
            //    UpdatedBy = n.UpdatedBy,
            //    CreatedDate = n.CreatedDate,
            //    UpdatedDate = n.UpdatedDate,
            //    //commentsMaster = (from cm in db.CommentsMasters
            //    //                 join cd in db.CommentDetails
            //    //                 on cm.CommentId equals cd.CommentId
            //    //                 where cd.MasterID == n.NewsId
            //    //                 && cd.MapMasterID == 1
            //    //                 select cm).ToList(),

            //    //commentsMaster = db.CommentsMasters.Where(x => x.CommentDetails==db.CommentDetails.Where(d => d.MasterID == n.NewsId).Where(m => m.MapMasterID == 1))


            //}).ToList();

            return News;
        }

        public NewsMaster getNews(int NewsID)
        {
           

            NewsMaster News = (from n in db.NewsMasters
                                     where n.IsActive == true && n.NewsId==NewsID
                                     select n).FirstOrDefault();
           

            return News;
        }

        public int updateLikes(int NewsID, string likeunlik)
        {

            NewsMaster News = (from n in db.NewsMasters
                               where n.IsActive == true && n.NewsId == NewsID
                               select n).SingleOrDefault();
            if (likeunlik.ToUpper() == "LIKE")
                News.Likes = News.Likes + 1;
            else
                News.Likes = News.Likes - 1;
            if (News.Likes < 0)
                News.Likes = 0;
            db.SaveChanges();
            return (int)News.Likes;
        }
        public int AddComments(Comments_News_Master Comment)
        {
            try
            {

           
            db.Comments_News_Master.Add(Comment);

          
            db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return 0;
        }

    }
}
