using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        public int ID { set; get; }
        public string Name { set; get;}
        public string Department { set; get; }
    }
}
