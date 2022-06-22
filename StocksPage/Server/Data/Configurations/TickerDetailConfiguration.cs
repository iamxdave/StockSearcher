using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StocksPage.Server.Models;

namespace StocksPage.Server.Data.Configurations
{
    public class TickerDetailConfiguration : IEntityTypeConfiguration<TickerDetail>
    {
        public void Configure(EntityTypeBuilder<TickerDetail> builder)
        {
            builder.ToTable("TickerDetail");
            builder.HasKey(e => e.IdTickerDetail);

            builder.Property(e => e.LogoUrl).IsRequired();
            builder.Property(e => e.Ticker).IsRequired();
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.SicDescription).IsRequired();
            builder.Property(e => e.Country).IsRequired();
            builder.Property(e => e.Currency).IsRequired();
            builder.Property(e => e.Cik).IsRequired();
            builder.Property(e => e.Description).IsRequired();
            builder.Property(e => e.TotalEmployees).IsRequired();
            builder.Property(e => e.Homepage).IsRequired();

            builder.HasOne(e => e.WatchlistTickerDetail)
                .WithMany(e => e.TickerDetails)
                .HasForeignKey(e => e.IdWatchlistTickerDetail)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
