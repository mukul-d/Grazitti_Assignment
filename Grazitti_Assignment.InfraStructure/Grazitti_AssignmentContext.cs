using Grazitti_Assignment.Core.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace Grazitti_Assignment.InfraStructure
{
  public class GrazittiDbContext : ApiAuthorizationDbContext<User>
  {
    public GrazittiDbContext(DbContextOptions<GrazittiDbContext> contextOptions,
      IOptions<OperationalStoreOptions> operationalStoreOptions) : base(contextOptions, operationalStoreOptions)
    {

    }
    public DbSet<Student> Students { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
  }
}