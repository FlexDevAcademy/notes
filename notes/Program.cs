using Microsoft.EntityFrameworkCore;
using notes.Data;
using notes.Services;

namespace notes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<NotesContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("NotesContext")));

            builder.Services.AddTransient<INoteService, NoteService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            else
            {
                app.UseDeveloperExceptionPage();
            }
            /*
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<NotesContext>();
                context.Database.EnsureCreated();
                await DbInitializer.Initialize(context);
            }*/

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Notebook}/{action=Index}/{id?}");

            app.Run();
        }
    }
}