using System.Net;
using LiveStreamingServerNet;
using LiveStreamingServerNet.Flv.Installer;
using LiveStreamingServerNet.Networking.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TeamHost.Application;
using TeamHost.Domain.Entities;
using TeamHost.Infrastructure;
using TeamHost.Persistence;
using TeamHost.Persistence.Context;
using TeamHost.Persistence.Extensions;

await using var lSServer = LiveStreamingServerBuilder.Create().ConfigureRtmpServer(options => options.AddFlv()).ConfigureLogging(options => options.AddConsole()).Build();
var blr = WebApplication.CreateBuilder(args);
blr.Services.AddControllersWithViews();
blr.Services.AddDbContext<EfContext>(opt =>
    opt.UseNpgsql(blr.Configuration.GetConnectionString("DefaultConnection"))).Configure<IdentityOptions>(opt =>{
        opt.Password.RequireDigit = false;
        opt.Password.RequireUppercase = false;
        opt.Password.RequireNonAlphanumeric = false;
        opt.Password.RequiredLength = 5;
    }).AddIdentity<User, IdentityRole<Guid>>().AddDefaultTokenProviders().AddEntityFrameworkStores<EfContext>();

blr.Services.ConfigureApplicationCookie(options =>{
    options.LoginPath = "/Account/Profile/Login";
});
blr.Services.AddInfrastructure();
blr.Services.AddPersistenceLayer();
blr.Services.AddApplicationLayer();
blr.Services.AddBackgroundServer(lSServer, new IPEndPoint(IPAddress.Any, 1935));
var app = blr.Build();
using var scope = app.Services.CreateScope();
var seeder = scope.ServiceProvider.GetRequiredService<IDbSeeder>();
var mig = scope.ServiceProvider.GetRequiredService<Migrator>();
await seeder.SeedAsync(new CancellationToken());
await mig.MigrateAsync();
if (!app.Environment.IsDevelopment()){
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseWebSockets();
app.UseWebSocketFlv(lSServer);
app.UseHttpFlv(lSServer);
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(name: "Pages", pattern: "{area=Home}/{controller=Home}/{action=Index}/{id?}");
app.Run();