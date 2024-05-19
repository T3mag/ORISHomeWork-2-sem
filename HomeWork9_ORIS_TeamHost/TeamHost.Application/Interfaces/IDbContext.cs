using Microsoft.EntityFrameworkCore;
using TeamHost.Domain.Entities;
using TeamHost.Domain.Entities.Chats;
namespace TeamHost.Application.Interfaces;
public interface IDbContext{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Developer> Developers { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<MediaFile> MediaFiles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserInfo> UserInfos { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<Messages> Messages { get; set; }
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}