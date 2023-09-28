using AutoMapper;
using DesafioCDC.DataAccess;
using DesafioCDC.Domain.Entities;
using DesafioCDC.Domain.Repositories;
using DesafioCDC.Domain.Requests;
using DesafioCDC.Validations;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
//builder.Services.AddTransient<IValidationAttributeAdapterProvider, ValidationAttributeAdapterProvider>();
builder.Services.AddControllers()
    .AddMvcOptions(options =>
    {
        options.ModelMetadataDetailsProviders.Add(
            new SuppressChildValidationMetadataProvider(typeof(CustomIsUniqueValidation)));
    });
var config = new AutoMapper.MapperConfiguration(cfg =>
{
    cfg.CreateMap<AuthorRequest, Author>();
    cfg.CreateMap<CategoryRequest, Category>();
});
IMapper mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
