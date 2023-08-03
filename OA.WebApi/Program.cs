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
builder.Services.AddScoped(typeof(ICountryRepo), typeof(CountryRepo));
builder.Services.AddScoped(typeof(IStateRepo), typeof(StateRepo));
builder.Services.AddScoped(typeof(ICityRepo), typeof(CityRepo));
builder.Services.AddScoped(typeof(IEmployeeService), typeof(EmployeeService));
builder.Services.AddScoped(typeof(ICountryService), typeof(CountryService));
builder.Services.AddScoped(typeof(IStateService), typeof(StateService));
builder.Services.AddScoped(typeof(ICityService), typeof(CityService));
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
