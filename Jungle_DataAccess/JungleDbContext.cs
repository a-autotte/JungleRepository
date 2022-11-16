using Jungle_Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_DataAccess
{
  public class JungleDbContext : IdentityDbContext<IdentityUser>
    {
    public JungleDbContext(DbContextOptions<JungleDbContext> options) : base(options)
    {
    
    }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.GenerateData();
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Guide> Guide { get; set; }
    public DbSet<Travel> Travel { get; set; }
    public DbSet<TravelRecommendation> TravelRecommendation { get; set; }
    public DbSet<Destination> Destination { get; set; }
    public DbSet<Country> Country { get; set; }
        public DbSet<HistoriqueTravel> historiqueTravel { get; set; }

  }
}
