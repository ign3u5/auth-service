using AuthService.IdentityServer;

var appBuilder = WebApplication.CreateBuilder(args);
appBuilder.Services.AddIdentityServer()
    .AddInMemoryApiScopes(Config.ApiScopes)
    .AddInMemoryClients(Config.Clients);

var webApp = appBuilder.Build();
webApp.UseIdentityServer();

webApp.Run("https://*:5001");