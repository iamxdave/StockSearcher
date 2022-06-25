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

            builder.Property(e => e.LogoUrl);
            builder.Property(e => e.Ticker).IsRequired();
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.SicDescription);
            builder.Property(e => e.Country);
            builder.Property(e => e.Currency);
            builder.Property(e => e.Cik);
            builder.Property(e => e.Description);
            builder.Property(e => e.TotalEmployees);
            builder.Property(e => e.Homepage);


        }
    }
}
