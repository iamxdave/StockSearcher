using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StocksPage.Server.Data.Configurations;
using StocksPage.Server.Models;

namespace StocksPage.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public DbSet<TickerName> TickerNames { get; set; }
        public DbSet<TickerDetail> TickerDetails { get; set; }
        public DbSet<WatchlistTickerDetail> WatchlistTickerDetails { get; set; }

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TickerNameConfiguration());
            modelBuilder.ApplyConfiguration(new TickerDetailConfiguration());
            modelBuilder.ApplyConfiguration(new WatchlistTickerDetailConfiguration());
        }
    }
}