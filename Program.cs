using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ToolBrowser;

var host = new HostBuilder()
    .UseConsoleLifetime()
    .ConfigureServices(ConfigureServices)
    .Build();

var toolBrowser = host.Services.GetRequiredService<IToolBrowser>();
await toolBrowser.Execute();

void ConfigureServices(HostBuilderContext _, IServiceCollection services)
{
    services.AddSingleton<IToolBrowser, ToolBrowser.ToolBrowser>();
}
