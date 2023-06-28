using EasyCup.Domain;
using EasyCup.Domain.Interface;
using EasyCup.Repository.Context;
using EasyCup.Repository.Repository;
using EasyCup.Service.Services;
using EasyCup.Service.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationDb"), opt =>
    {
        opt.CommandTimeout(180);
        opt.EnableRetryOnFailure(5);
    });
});

builder.Services.AddTransient<IFootballSchoolService, FootballSchollService>();

builder.Services.AddScoped<IRepository<Championship>, ApplicationRepository<Championship>>();
builder.Services.AddScoped<IRepository<ChampionshipTeamPlayer>, ApplicationRepository<ChampionshipTeamPlayer>>();
builder.Services.AddScoped<IRepository<CupManager>, ApplicationRepository<CupManager>>();
builder.Services.AddScoped<IRepository<FootballSchool>, ApplicationRepository<FootballSchool>>();
builder.Services.AddScoped<IRepository<FootballSchoolUnit>, ApplicationRepository<FootballSchoolUnit>>();
builder.Services.AddScoped<IRepository<FutsalCourt>, ApplicationRepository<FutsalCourt>>();
builder.Services.AddScoped<IRepository<Match>, ApplicationRepository<Match>>();
builder.Services.AddScoped<IRepository<Player>, ApplicationRepository<Player>>();
builder.Services.AddScoped<IRepository<Team>, ApplicationRepository<Team>>();


//Unable to resolve service for type 'Microsoft.EntityFrameworkCore.DbContext' while attempting to activate 'EasyCup.Repository.Repository.ApplicationRepository`1[EasyCup.Domain.FootballSchool]'.

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
