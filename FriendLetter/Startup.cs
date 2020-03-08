// This file is required in every ASP.NET Core MVC project. It provides instructions on compiling and running a web application.

// These import built-in .NET namespaces that are required for creating a web application. They can help us construct HTTP requests, configure our project, and ensure necessary built-in functionality is present in the correct areas.
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace FriendLetter
{
  public class Startup
  {
    // A constructor which will create an iteration of the Startup class that contains specific settings and variables to run our project successfully. It's required for configuring a basic ASP.NET Core MVC project.
    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
        .SetBasePath(env.ContentRootPath)
        .AddEnvironmentVariables();
      Configuration = builder.Build();
    }

    public IConfigurationRoot Configuration { get; }

    // A required built-in method used to set up an application's server. We can use it to configure other framework services. For instance, services.AddMvc() adds the MVC service to the project. This is a bit like ensuring our dependencies are available in the necessary areas.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
    }

    // A built-in method that is required in all ASP.NET Core apps. ASP.NET calls Configure() when the app launches. It's responsible for telling our app how to handle requests to the server.
    public void Configure(IApplicationBuilder app)
    {
      // Tells our app to use the MVC framework to respond to HTTP requests. This block of code also sets up default routing for our application. It tells the project to use the Index action of the Home Controller as the default route.
      app.UseMvc(routes =>
      {
        routes.MapRoute(
          name: "default",
          template: "{controller=Home}/{action=Index}/{id?}");
      });

      // Not actually required to successfully launch our project. However, it will allow us to test that our Configure() method is working properly.
      app.Run(async (context) =>
      {
        await context.Response.WriteAsync("Hello World!");
      });

      // Useful for debugging. Will produce a friendly error report if Razor fails to load.
      app.UseDeveloperExceptionPage();
    }

  }
}