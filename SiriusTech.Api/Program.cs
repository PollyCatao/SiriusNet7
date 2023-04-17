using SiriusTech.Api.Config;
using SiriusTech.Data.Repositories;
using SiriusTech.Domain.Interfaces.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Add services Swagger.
builder.Services.AddSwaggerGen();

// Add services Scoped.
builder.Services.AddScoped<IEntidadeRepository, EntidadeRepository>();

// Add service AutoMapping
builder.Services.AddAutoMapper(typeof(EntitiesToDTO));



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
