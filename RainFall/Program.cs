using Microsoft.Extensions.Options;
using RainFall;
using RainFall.Services;

var builder = WebApplication.CreateBuilder(args);

// Base URL Config
builder.Services.Configure<FloodMonitoringApiOptions>(builder.Configuration.GetSection("FloodMonitoringApi"));

// Services
builder.Services.AddHttpClient<FloodMonitoringService>((serviceProvider, client) =>
{
    var options = serviceProvider.GetRequiredService<IOptions<FloodMonitoringApiOptions>>().Value;
    client.BaseAddress = new Uri(options.BaseUrl);
});

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