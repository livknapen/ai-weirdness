using AI_WeirdnessAPI.Models;
using AI_WeirdnessAPI.Services;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//mapping the settings form the JSON to the class AiWeirdnessDatabaseSettings.
builder.Services.Configure<AiWeirdnessDatabaseSettings>(
	builder.Configuration.GetSection(nameof(AiWeirdnessDatabaseSettings)));

builder.Services.AddSingleton<IAiWeirdnessDatabaseSettings>(sp =>
	sp.GetRequiredService<IOptions<AiWeirdnessDatabaseSettings>>().Value);

//specify where the database connections needs to be read from.
builder.Services.AddSingleton<IMongoClient>(s =>
	new MongoClient(builder.Configuration.GetValue<string>("AiWeirdnessDatabaseSettings:ConnectionString")));

builder.Services.AddScoped<IUserService, UserService>();

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
