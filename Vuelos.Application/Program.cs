using Domain.Servicios.Implementacion;
using Domain.Servicios.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Text;
using Vuelos.DataAccess.Repositorio.Implementaciones;
using Vuelos.DataAccess.Repositorio.Interfaces;
using Vuelos.Entities;
using Vuelos.Entities.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<VuelosContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Vuelos")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inyeccion de Dependencias
builder.Services.AddScoped<IUnidadDeTrabajo, UnidadDeTrrabajo>();
builder.Services.AddScoped<IAuthService, AuthServicio>();

//AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));
//JWT
builder.Services.AddSwaggerGen(options => {
    options.AddSecurityDefinition("jwt", new OpenApiSecurityScheme
    {
        Description = "Standar Authorization Header using JWTToken",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey

    });
    options.OperationFilter<SecurityRequirementsOperationFilter>();
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer
    (options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration
            .GetSection("AppSettings:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

//cors
string policy = "MyPolicy";


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policy, builder =>
      builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost")
      .AllowAnyHeader().AllowAnyMethod());

});


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

app.UseCors(policy);

app.Run();
