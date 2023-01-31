using Machine_assest.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<MachineAssetRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddMvc(setupAction =>
{
    setupAction.Filters.Add(
       new ProducesResponseTypeAttribute(StatusCodes.Status400BadRequest));
    setupAction.Filters.Add(
        new ProducesResponseTypeAttribute(StatusCodes.Status406NotAcceptable));
    setupAction.Filters.Add(
        new ProducesResponseTypeAttribute(StatusCodes.Status500InternalServerError));
});
builder.Services.AddSwaggerGen(setupAction =>
{
    //SwaggerDoc provides name for the swagger doc.
    //OpenApiInfo provides additional information to swagger doc
    setupAction.SwaggerDoc("MachineAssetAPISepcification", new Microsoft.OpenApi.Models.OpenApiInfo()
    {
        Title = "Machine Asset API"
    });
    var xmlfile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlfullpath = Path.Combine(AppContext.BaseDirectory, xmlfile);
    setupAction.IncludeXmlComments(xmlfullpath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI(setupAction =>
    {
        setupAction.SwaggerEndpoint("/swagger/MachineAssetAPISepcification/swagger.json", "Machine Asset API");
    });
   
}

app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.Run();
