var builder = WebApplication.CreateBuilder(args);
// Add SignalR
builder.Services.AddSignalR();
var app = builder.Build();
app.MapHub<LobbyHub>("/lobby");
app.Run();