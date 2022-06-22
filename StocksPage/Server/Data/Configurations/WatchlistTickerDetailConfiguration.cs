using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StocksPage.Server.Models;

namespace StocksPage.Server.Data.Configurations
{
    public class WatchlistTickerDetailConfiguration : IEntityTypeConfiguration<WatchlistTickerDetail>
    {
        public void Configure(EntityTypeBuilder<WatchlistTickerDetail> builder)
        {
            builder.ToTable("WatchlistTickerDetail");
            builder.HasKey(e => e.IdWatchlistTickerDetail);
            builder.HasData(new WatchlistTickerDetail
            {
                IdWatchlistTickerDetail = 1,
            });
        }
    }
}
