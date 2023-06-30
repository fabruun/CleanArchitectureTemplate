var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new() { Title = "CleanArchitecture.Api", Version = "v1" });
    });
    builder.Services.AddApplication();
    builder.Services.AddInfrastructure();
}

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CleanArchitecture.Api v1"));
app.UseHttpsRedirection();
app.MapControllers();

app.Run();