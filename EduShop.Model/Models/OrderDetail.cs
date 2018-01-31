using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduShop.Model.Models
{
    [Table("OrderDeatails")]
   public class OrderDetail
    {
        [Key]
        public int OrderID { set; get; }
        [Key]
        public int ProductID { set; get; }
        public int Quantity { set; get; }
        
        public virtual Order Order { set; get; }

    }
}
