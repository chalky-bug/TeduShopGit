using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomName { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomAddress { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomEmail { get; set; }

        [Required]
        [MaxLength(50)]
        public string CustomMobie { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomMessage { get; set; }

        [MaxLength(256)]
        public string PaymentMethod { get; set; }



        public DateTime? CreatDate { get; set; }

        public string CreateBy { get; set; }

        public string PaymentStatus { get; set; }

        public string Status { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetail { set; get; }

    }
}
