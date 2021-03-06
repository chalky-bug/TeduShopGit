﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("SystemConfigs")]
   public class VisitorStatistic
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public DateTime VisitedDate { get; set; }
        [MaxLength(50)]
        public string IPAddress { get; set; }
    }
}
