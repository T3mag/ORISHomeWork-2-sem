using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeamHost.Application.Interfaces;
using TeamHost.Domain.Entities;
using TeamHost.Domain.Entities.Chats;
using TeamHost.Persistence.Configurations;
namespace TeamHost.Persistence.Context;
public class EfContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>, IDbContext{
    public EfContext(DbContextOptions<EfContext> options): base(options){}
    public DbSet<Category> Categories { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Developer> Developers { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<MediaFile> MediaFiles { get; set; }
    public DbSet<UserInfo> UserInfos { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<Messages> Messages { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new CountryConfiguration());
        modelBuilder.ApplyConfiguration(new DeveloperConfiguration());
        modelBuilder.ApplyConfiguration(new GameConfiguration());
        modelBuilder.ApplyConfiguration(new MediaFileConfiguration());
        modelBuilder.ApplyConfiguration(new UserInfoConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}