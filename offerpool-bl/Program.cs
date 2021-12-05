using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using offerpool_bl.Data;

var AllowSpecificOrigins = "_allowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

//CORS policy
builder.Services.AddCors( options => 
{
    options.AddPolicy(name: AllowSpecificOrigins, builder => 
    {
        builder.WithOrigins("http://localhost:3000","https://localhost:7080")
        .AllowAnyHeader();
    });
});
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(options=>options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.UseCors(AllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();