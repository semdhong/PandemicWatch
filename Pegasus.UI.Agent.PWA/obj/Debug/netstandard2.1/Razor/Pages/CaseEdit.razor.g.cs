#pragma checksum "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\Pages\CaseEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "017df3095f228ced658e9e050c5a5bf4a764ac67"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/cases/edit/{brgyId:int}")]
    public partial class CaseEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Barangay</h3>\r\n");
            __builder.OpenComponent<Pegasus.UI.Agent.PWA.Pages.CaseForm>(1);
            __builder.AddAttribute(2, "Person", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Pegagus.UI.Agent.PWA.Profiles.PersonProfilesModel>(
#nullable restore
#line 6 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\Pages\CaseEdit.razor"
                   brgymodel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ButtonText", "Save");
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 6 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\Pages\CaseEdit.razor"
                                                                EditBrgy

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Agent.PWA\Pages\CaseEdit.razor"
       
    [Parameter] public int brgyId { get; set; }
    PersonProfilesModel brgymodel = new PersonProfilesModel();

    protected async override Task OnParametersSetAsync()
    {
        brgymodel = await http.GetFromJsonAsync<PersonProfilesModel>($"https://localhost:44326/api/Person/" + brgyId);
    }

    async Task EditBrgy()
    {
        await http.PutAsJsonAsync("https://localhost:44326/api/Person", brgymodel);
        navmgr.NavigateTo("/cases");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navmgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
