using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add DbContext and use SQLite
builder.Services.AddDbContext<WarehouseDbContext>(options =>
    options.UseSqlite("Data Source=warehouse.db"));

// Add CORS support
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorClient",
        policy => policy.WithOrigins("http://localhost:5059") // URL of your Blazor app
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});

var app = builder.Build();

// Use CORS
app.UseCors("AllowBlazorClient");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
