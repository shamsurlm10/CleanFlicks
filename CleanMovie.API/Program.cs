using ClassMovie.Domain.Dtos;
using CleanMovie.Application.Interfaces;
using CleanMovie.Application.Repositories;
using CleanMovie.Application.Services;
using CleanMovie.Application.Services.Base;
using CleanMovie.Infrastructure;
using CleanMovie.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager config = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

builder.Services.InfrastructurePersistence(builder.Configuration);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add Database Service
builder.Services.AddTransient<IEmailService, EmailService>();

builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();

builder.Services.AddScoped<IMemberService, MemberService>();
builder.Services.AddScoped<IMemberRepository, MemeberRepository>();

builder.Services.AddScoped<IRentalService, RentalService>();
builder.Services.AddScoped<IRentalRepository, RentalRepository>();

builder.Services.AddScoped<IMovieRentalService, MovieRentalService>();
builder.Services.AddScoped<IMovieRentalRepository, MovieRentalRepository>();

builder.Services.AddScoped<DbContext, MovieDbContext>();
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
