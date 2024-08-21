using Autofac.Extensions.DependencyInjection;
using Autofac;
using Northwind.Business.Dependency_Resolvers;

namespace Northwind.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

            builder.Host.ConfigureContainer<ContainerBuilder>(bldr =>
            {

                bldr.RegisterModule(new AutofacBusinessModule());
            });

            builder.Services.AddControllers();
      
            // Changed to Autofac : 
            //builder.Services.AddSingleton<IProductService, ProductManager>();
                                                                              
            //builder.Services.AddSingleton<IProductDal, EfProductDal>();  

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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
