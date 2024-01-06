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
        public DbSet<UserData> UserDatas { get; set; }
        public DbSet<BlogData> BlogDatas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
          modelbuilder.Entity<BlogData>().HasData(
          new BlogData { Id = 1, Name = "Shahadat", Title = "Title1", Summary = "Summary1", Details="Details1",Thumnail="~/image/avenue-815297_640.jpg" },
          new BlogData { Id = 2, Name = "Emran", Title = "Title2", Summary = "Summary2", Details = "Details2", Thumnail = "~/image/download(1).jpg" },
          new BlogData { Id = 3, Name = "Mahfuz", Title = "Title3", Summary = "Summary3", Details = "Details3", Thumnail = "~/image/download.jpg" }
          );
        }

    }
}
