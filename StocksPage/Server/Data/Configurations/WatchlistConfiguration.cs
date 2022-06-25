using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StocksPage.Server.Models;

namespace StocksPage.Server.Data.Configurations
{
    public class WatchlistConfiguration : IEntityTypeConfiguration<Watchlist>
    {
        public void Configure(EntityTypeBuilder<Watchlist> builder)
        {
            builder.ToTable("Watchlist");
            builder.HasKey(e => e.IdWatchlist);

            builder.HasOne(e => e.User)
                .WithMany(e => e.Watchlist)
                .HasForeignKey(e => e.IdUser)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.TickerDetail)
                .WithMany(e => e.Watchlist)
                .HasForeignKey(e => e.IdTickerDetail)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
