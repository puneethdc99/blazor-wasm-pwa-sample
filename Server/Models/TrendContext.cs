using Microsoft.EntityFrameworkCore;
using TrendModelService.Shared;
namespace TrendModelService.Server.Models {
    public class TrendContext : DbContext {
        public TrendContext (DbContextOptions<TrendContext> options) : base (options) { }
        public DbSet<Trend> Trends { get; set; }
    }
}