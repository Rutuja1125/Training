using Demo;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.AddDbContext();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.AddSwaggerDoccumentation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(setupAction =>
    {
        setupAction.SwaggerEndpoint("/swagger/DemoOpenAPISpecification/swagger.json", "Demo API");
    });

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
