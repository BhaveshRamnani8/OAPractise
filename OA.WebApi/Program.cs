using Microsoft.EntityFrameworkCore;
using OA.Data;
using OA.Repo;
using OA.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<OAContext>(c => c.UseSqlServer(builder.Configuration.GetConnectionString("SqlConn")));
builder.Services.AddScoped(typeof(IRepository), typeof(Repository));
builder.Services.AddScoped(typeof(IEmployeeService), typeof(EmployeeService));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
