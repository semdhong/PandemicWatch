using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using System.Threading;
using Radzen;
using Syncfusion.EJ2.Blazor;
namespace Pegasus.UI.Agent.PWA
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzM3NEAzMTM3MmUzNDJlMzBPRm41TTBEL2hiZ0pjbG93dDZPQ0VocmRCWkJHSXlzWFgrUkxrZVlDaUpzPQ==");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddScoped<DialogService>();
            builder.Services.AddScoped<NotificationService>();
            await builder.Build().RunAsync();
        }
        public class IncludeRequestCredentialsMessageHandler : DelegatingHandler
        {
            protected override Task<HttpResponseMessage> SendAsync(
                HttpRequestMessage request, CancellationToken cancellationToken)
            {
                request.SetBrowserRequestCredentials(BrowserRequestCredentials.Include);
                return base.SendAsync(request, cancellationToken);
            }
        }
    }
}
