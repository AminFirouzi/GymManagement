var builder = WebApplication.CreateBuilder(args);

// 1. Register controller services in the DI container
builder.Services.AddControllers();

// If your template has OpenAPI/Swagger setup, keep it, otherwise this is fine for now
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();

// 2. Tell the HTTP pipeline to map requests to your controllers
app.MapControllers();

app.Run();