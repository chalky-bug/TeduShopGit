using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { get; set; }

        [Key]
        public int ProductID { get; set; }

        public int  Quantitty { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}
