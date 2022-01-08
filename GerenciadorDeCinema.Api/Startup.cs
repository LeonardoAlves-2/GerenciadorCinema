using GerenciadorDeCinema.Infraestrutura;
using GerenciadorDeCinema.Infraestrutura.Repositorios;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using GerenciadorDeCinema.Servico;
using GerenciadorDeCinema.Servico.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FluentValidation.AspNetCore;


namespace GerenciadorDeCinema.Api
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
            services.AddDbContext<DbContext, CinemaContext>();

            services.AddScoped<IFilmeRepositorio, FilmeRepositorio>();
            services.AddScoped<IFilmeService, FilmeService>();

            services.AddScoped<ISessaoRepositorio, SessaoRepositorio>();
            services.AddScoped<ISessaoService, SessaoService>();

            services.AddScoped<ISalaRepositorio, SalaRepositorio>();
            services.AddScoped<ISalaService, SalaService>();

            services.AddScoped<IFilmeValidator, FilmeValidator>();

            //services.AddMvc()
            //.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<FilmeValidator>());
            //services.AddMvc()
            //.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<SessaoValidator>());

            services.AddMvc();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DbContext context)
        {
            context.Database.Migrate();

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
