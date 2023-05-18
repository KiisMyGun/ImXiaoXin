using Microsoft.EntityFrameworkCore;

namespace ImXiaoXin.Site.Data
{
    public class SiteDbContext : DbContext
    {
        public SiteDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ToolInfo> ToolInfos { get; set; }
    }
}