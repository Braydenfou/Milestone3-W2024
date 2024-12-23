var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Temperature API Policy", policy =>
    {
        policy.WithOrigins("https://localhost:6002");
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(); //using string from above

app.MapGet("/temperature", () =>
{
    return new Random().Next(30, 90);
})
.WithName("GetTemperature")
.WithOpenApi()
.RequireCors("Temperature API Policy"); //cors is enabled

app.Run();
