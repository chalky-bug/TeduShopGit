using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model
{
    [Table("MenuGroups")]
    public class MenuGroup 
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual IEnumerable<Menu> Menus { get; set; }
    }
}