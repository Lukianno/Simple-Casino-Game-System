var builder = WebApplication.CreateBuilder(args);
// Add JWT
builder.Services.AddAuthentication("Bearer").AddJwtBearer();
builder.Services.AddControllers();
var app = builder.Build();
app.UseAuthentication();app.UseAuthorization();
app.MapControllers();
app.Run();