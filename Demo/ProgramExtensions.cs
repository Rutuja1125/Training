using Demo.Data;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace Demo
{       
    /// <summary>
    /// 
    /// </summary>
    public static class ProgramExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public static void AddDbContext(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<DemoContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("DemoContext") ?? throw new InvalidOperationException("Connection string 'DemoContext' not found.")));

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public static void AddSwaggerDoccumentation(this WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen(setupAction => Create(setupAction));


        }

        #region Private
        private static void Create(SwaggerGenOptions setupAction)
        {
            setupAction.SwaggerDoc("DemoOpenAPISpecification", new Microsoft.OpenApi.Models.OpenApiInfo()
            {
                Title = "Demo API",
                Description ="This app shows Employee and Office details."
            });
            var xmlfile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlfullpath = Path.Combine(AppContext.BaseDirectory, xmlfile);
            setupAction.IncludeXmlComments(xmlfullpath);

        }
        #endregion
    }
}
