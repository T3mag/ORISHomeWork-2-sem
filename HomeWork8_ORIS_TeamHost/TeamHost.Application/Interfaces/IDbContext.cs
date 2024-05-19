using Microsoft.EntityFrameworkCore;
using TeamHost.Domain.Entities;
namespace TeamHost.Application.Interfaces;
public interface IDbContext{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<StaticFile> StaticFiles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserInfo> UserInfos { get; set; }
}