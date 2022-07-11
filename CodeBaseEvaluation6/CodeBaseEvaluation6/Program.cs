using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CodeBaseEvaluation6.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CodeBaseEvaluation6Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CodeBaseEvaluation6Context") ?? throw new InvalidOperationException("Connection string 'CodeBaseEvaluation6Context' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseCors(builder => builder
.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader());

app.MapControllers();

app.Run();
