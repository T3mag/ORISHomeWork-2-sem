using System.Net;
using LiveStreamingServerNet;
using LiveStreamingServerNet.Flv.Installer;
using LiveStreamingServerNet.Networking.Helpers;

using var liveStreamingServer = LiveStreamingServerBuilder.Create().ConfigureRtmpServer(options => options.AddFlv()).ConfigureLogging(options => options.AddConsole()).Build();
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddBackgroundServer(liveStreamingServer, new IPEndPoint(IPAddress.Any, 1935));

var app = builder.Build();

if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseWebSockets();
app.UseWebSocketFlv(liveStreamingServer);
app.UseHttpFlv(liveStreamingServer);
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute( name: "Pages",pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();