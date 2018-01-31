using System;

namespace EduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreateDate { set; get; }
        string CreateBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }

        string MetaKeywork { set; get; }
        string MetaDescription { set; get; }

        bool Status { set; get; }
    }
}