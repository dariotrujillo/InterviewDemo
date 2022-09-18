global using InterviewDemo.DataContext;
using AutoMapper;
using InterviewDemo.Abstractions;
using InterviewDemo.Automapper;
using InterviewDemo.DTO;
using InterviewDemo.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataEFContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//Automapper
var mapperConfig = new MapperConfiguration(mc => {
    mc.AddProfile(new AutomapperProfiles());
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
//End Automapper

builder.Services.AddScoped<DataEFContext>();
builder.Services.AddScoped<IWarehouseService<WarehouseDTO>>(sv => new WarehouseService(sv.GetService<DataEFContext>(), mapper));
builder.Services.AddScoped<IPackageService<PackageDTO>>(sv => new PackageService(sv.GetService<DataEFContext>(), mapper));


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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
