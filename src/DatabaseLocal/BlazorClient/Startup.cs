using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;




namespace BlazorClient
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
