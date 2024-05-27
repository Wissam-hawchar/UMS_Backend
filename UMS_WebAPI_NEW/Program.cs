using Microsoft.EntityFrameworkCore;
using UMS_BLL.Mapping;
using UMS_BLL.Services.Faculties;
using UMS_BLL.Services.Majors;
using UMS_BLL.Services.Users;
using UMS_DAL.Models;
using UMS_DAL.Repositries.Faculties;
using UMS_DAL.Repositries.Majors;
using UMS_DAL.Repositries.Users;
using UMS_WebAPI_NEW.Extensions;
using UMS_WebAPI_NEW.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMappperConfig();
builder.Services.addDb(builder.Configuration);
builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddControllerServices();
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
