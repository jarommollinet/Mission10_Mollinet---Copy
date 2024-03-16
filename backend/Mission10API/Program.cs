using Microsoft.EntityFrameworkCore;
using Mission10API.Data;
using SQLitePCL;

// Initialize SQLitePCL to ensure the SQLite provider is correctly set up
Batteries_V2.Init();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();

builder.Services.AddDbContext<BowlingContext>(options =>
    options.UseSqlite(builder.Configuration["ConnectionStrings:BowlingConnection"]));

builder.Services.AddScoped<IBowlingRepository, EFBowlerRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(p => p.WithOrigins("http://localhost:3000"));

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
