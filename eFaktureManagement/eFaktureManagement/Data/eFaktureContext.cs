using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eFaktureManagement.Data
{
    public class eFaktureContext : IdentityDbContext
    {
        public eFaktureContext(DbContextOptions options) : base(options)
        {
        }
    }
}
