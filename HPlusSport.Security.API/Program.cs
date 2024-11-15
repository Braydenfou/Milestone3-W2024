var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Temperature API Policy", policy =>
    {
        policy.WithOrigins("http://localhost:6001") //changed due to bugs
              .AllowAnyMethod() //added this
              .AllowAnyHeader(); //and this
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

app.UseCors("Temperature API Policy"); //using string from above

app.MapGet("/temperature", () =>
{
    return new Random().Next(30, 90);
})
.WithName("GetTemperature")
.WithOpenApi()
.RequireCors("Temperature API Policy"); //cors is enabled

app.Run();
