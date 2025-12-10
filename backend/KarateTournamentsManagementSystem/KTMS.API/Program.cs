using KTMS.Application;
using KTMS.Application.Abstractions;
using KTMS.Infrastructure.Common;
using KTMS.Infrastructure.Database;
using KTMS.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace KTMS.API
{
    public partial class Program
    {
        
        public static void Main(string[] args)
        {
           var builder = WebApplication.CreateBuilder(args);

            //Register DbContext
            builder.Services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
                sqlOptions => sqlOptions.MigrationsAssembly("KTMS.Infrastructure"))
            );

            //IAppDbContext so DI can resolve it in handlers
            builder.Services.AddScoped<IAppDbContext>(provider => provider.GetService<DatabaseContext>());

            //Register JWT Service for IJwtService  
            builder.Services.AddScoped<IJwtService, JwtService>();

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Add Infrastructure Services
            builder.Services.AddInfrastructure(builder.Configuration);

            //Add Application
            builder.Services.AddApplication();

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
        }
    }
}
