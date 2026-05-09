
using Catalog.Infrastracture.Context;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddDbContext<CatalogDbContext>(option =>
            {
                var constr = builder.Configuration.GetConnectionString("CatalogConStr");
                if (string.IsNullOrEmpty(constr))
                    throw new Exception("Catalog Connection String is null");
                option.UseSqlServer(constr);
            });     

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
