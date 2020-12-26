

namespace Catstagram.Server.Data
{
    using Catstagram.Server.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    public class CatstagramDbContext : IdentityDbContext<User>
    {
        public CatstagramDbContext(DbContextOptions<CatstagramDbContext> options)
            : base(options)
        {
        }
    }
}
