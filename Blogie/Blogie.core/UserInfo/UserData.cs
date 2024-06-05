using Blogie.core.BlogInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogie.core.UserInfo
{
    public class UserData : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? ProfilePic { get; set; }
       // List<BlogData> BlogDatas { get; set; }  


    }
}
