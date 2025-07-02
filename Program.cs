using Pastry_And_Pour_Jurczak.Data;

namespace Pastry_And_Pour_Jurczak
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<MongoDBContext>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();

          
            app.UseStaticFiles();

            app.UseDefaultFiles();

            app.MapControllers();

            app.Run();
        }
    }
}
