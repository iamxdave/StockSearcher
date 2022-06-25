using Microsoft.AspNetCore.Identity;

namespace StocksPage.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual IEnumerable<Watchlist> Watchlist { get; set; }
    }
}