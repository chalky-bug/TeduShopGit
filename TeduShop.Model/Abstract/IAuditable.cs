using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? DateUpdate { get; set; }
        string UpdateBy { get; set; }

        string MetaKeywork { get; set; }
        string MetaDescription { get; set; }

        bool Status { set; get; }

    }
}
