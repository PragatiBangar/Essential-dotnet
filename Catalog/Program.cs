using CatalogService.Repositories;
using CatalogService.Repositories.Interfaces;
using CatalogService.Service.Interfaces;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.FileProviders;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors();
builder.Services.AddScoped<IProductRepository,ProductRepository>();
builder.Services.AddScoped<IProductService,ProductService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// builder.Services.Configure<FormOptions>(o =>
// {
//     o.ValueLengthLimit = int.MaxValue;
//     o.MultipartBodyLengthLimit = int.MaxValue;
//     o.MemoryBufferThreshold = int.MaxValue;
// });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// app.UseCors(x => x.AllowAnyOrigin()
//                    .AllowAnyMethod()
//                    .AllowAnyHeader());
                   
app.UseAuthorization();

app.MapControllers();

app.Run();
