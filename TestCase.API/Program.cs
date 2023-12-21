using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Text.Json.Serialization;
using TestCase.API.ValidationProfiles;
using TestCase.Core.OrderInterface;
using TestCase.Core.Repositories;
using TestCase.Core.Services;
using TestCase.Repository;
using TestCase.Repository.Repositories;
using TestCase.Service;
using TestCase.Service.AutoMapper;
using TestCase.Service.Services;

var builder = WebApplication.CreateBuilder(args);
var services=builder.Services;
// Add services to the container.

builder.Services.AddControllersWithViews().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
services.AddDbContext<EfDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"));
});

services.AddFluentValidation(options =>
{
    options.RegisterValidatorsFromAssemblyContaining<FluentValidationAssemblySelector>();
});

services.AddAutoMapper(typeof(AutoMapperAssemblySelector));

//IOContainer 
services.AddScoped<DbContext,EfDbContext>();

services.AddScoped<IUnitOfWorks, UnitOfWorks>();

services.AddScoped<IProductRepository, ProductRepository>();
services.AddScoped<IProductService, ProductService>();

services.AddScoped<IEmployeeRepository, EmployeeRepository>();
services.AddScoped<IEmployeeService, EmployeeService>();


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
