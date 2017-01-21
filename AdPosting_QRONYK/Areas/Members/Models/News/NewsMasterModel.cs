using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace AdPosting_QRONYK.Areas.Members.Models.News
{
    public class NewsMasterModel
    {
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int Likes { get; set; }
        public string Location_Name { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public List<CommentsMaster> commentsMaster { get; set; }
    }

    public partial class CommentsMaster
    {
        public CommentsMaster()
        {
            this.CommentDetails = new HashSet<CommentDetail>();
        }

        public int CommentId { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        public virtual ICollection<CommentDetail> CommentDetails { get; set; }
        public virtual CommentsMaster CommentsMaster1 { get; set; }
        public virtual CommentsMaster CommentsMaster2 { get; set; }
    }

    public partial class CommentDetail
    {
        public int CommentDetailsID { get; set; }
        public int CommentId { get; set; }
        public int MapMasterID { get; set; }
        public int MasterID { get; set; }

        public virtual CommentsMaster CommentsMaster { get; set; }
        public virtual CommentsMappingMaster CommentsMappingMaster { get; set; }
    }

    public partial class CommentsMappingMaster
    {
        public CommentsMappingMaster()
        {
            this.CommentDetails = new HashSet<CommentDetail>();
        }

        public int MapMasterID { get; set; }
        public string MasterName { get; set; }

        public virtual ICollection<CommentDetail> CommentDetails { get; set; }
    }
   
}
