using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogie.core.BlogInfo
{
    public class BlogData : BaseEntity
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Thumnail { get; set; }
        public string Details { get; set; }


    }
}
