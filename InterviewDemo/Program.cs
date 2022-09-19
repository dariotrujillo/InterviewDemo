global using InterviewDemo.DataContext;
using AutoMapper;
using InterviewDemo.Abstractions;
using InterviewDemo.Automapper;
using InterviewDemo.DTO;
using InterviewDemo.Serializers;
using InterviewDemo.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;
using System.Text.Json;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
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

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("http://localhost:5173",
                                              "https://localhost:5173",
                                              "https://localhost:7216")
                                                .AllowAnyMethod()
                                                .AllowAnyOrigin()
                                                .AllowAnyHeader(); 
                      });
});

builder.Services.AddControllers()
    .AddJsonOptions(options => {
        options.JsonSerializerOptions.Converters.Add(new IntToStringConverter());
        options.JsonSerializerOptions.NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString;
        }
    );

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Enable Cors
app.UseCors(MyAllowSpecificOrigins);

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
