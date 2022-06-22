using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StocksPage.Server.Models;

namespace StocksPage.Server.Data.Configurations
{
    public class TickerNameConfiguration : IEntityTypeConfiguration<TickerName>
    {
        public void Configure(EntityTypeBuilder<TickerName> builder)
        {
            builder.ToTable("TickerName");
            builder.HasKey(e => e.IdTickerName);

            builder.Property(e => e.Ticker).IsRequired();
            builder.Property(e => e.Name).IsRequired();
        }
    }
}
