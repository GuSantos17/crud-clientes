using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TesteBRQ.CrudUsers.Domain;
using TesteBRQ.CrudUsers.Infra.Context;
using TesteBRQ.CrudUsers.Infra.Repository;
using TesteBRQ.CrudUsers.Infra.UnitOfWork;
using TesteBRQ.CrudUsers.Util.Interface;
using TesteBRQ.CrudUsers.Util.Mappers;
using testebrq_crud_user.Application.Interface;
using testebrq_crud_user.Application.Service;
using Microsoft.EntityFrameworkCore;

namespace testebrq_crud_users
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();

            #region Application Service
            services.AddTransient<IServiceUser, ServiceUser>();
            #endregion

            #region Repositorys SQL
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            #endregion

            #region Mapper
            services.AddScoped<IMapperUser, MapperUser>();
            #endregion

            services.AddDbContext<CrudUsersContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
               );

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
