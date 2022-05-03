using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tomlyn.Extensions.Configuration;
using ToolBrowser;

var host = new HostBuilder()
    .UseConsoleLifetime()
    .ConfigureAppConfiguration(ConfigureAppConfiguration)
    .ConfigureServices(ConfigureServices)
    .Build();

var toolBrowser = host.Services.GetRequiredService<IToolBrowser>();
await toolBrowser.Execute();

void ConfigureAppConfiguration(HostBuilderContext _, IConfigurationBuilder config)
{
    config.AddTomlFile("appsettings.toml", true, false);
}

void ConfigureServices(HostBuilderContext _, IServiceCollection services)
{
    services.AddSingleton<IToolBrowser, ToolBrowser.ToolBrowser>();
}
