#pragma checksum "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b43d78e0b632b6466fce81ab37226e3fd14b55b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Pegasus.UI.Agent.PWA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\_Imports.razor"
using Pegasus.UI.Agent.PWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\_Imports.razor"
using Pegasus.UI.Agent.PWA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\_Imports.razor"
using Pegagus.UI.Agent.PWA.Maintenance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\_Imports.razor"
using Pegagus.UI.Agent.PWA.Profiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\Pages\Index.razor"
       
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string userInput;
    private string messageInput;

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("https://localhost:44376/broadcastHub"))
            .Build();

        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            var encodedMsg = $"{user}: {message}";
            messages.Add(encodedMsg);
            StateHasChanged();
        });

        await hubConnection.StartAsync();
    }

    Task Send() =>
        hubConnection.SendAsync("SendMessage", userInput, messageInput);

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public void Dispose()
    {
        _ = hubConnection.DisposeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
