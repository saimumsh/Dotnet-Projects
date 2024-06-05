using Blogie.core.BlogInfo;
using Blogie.core.UserInfo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogie.data.DataBlog
{
    public class BlogDbContext : DbContext 
	{
		public BlogDbContext(DbContextOptions<BlogDbContext> Options) : base(Options) { }
        public  DbSet<UserData> UserDatas { get; set; }
        public  DbSet<BlogData> BlogDatas { get; set; }

    }
}
