#pragma checksum "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\Pages\BarangayMap.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb6cc5af9f6dc5d7873caeda4193d5904dcb6ed9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Pegasus.UI.Admin.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Pegasus.UI.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Pegasus.UI.Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Pegasus.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Pegasus.Models.Maintenance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Pegasus.Models.Profiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/brgymap")]
    public partial class BarangayMap : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pandemic Watch\PandemicWatch\Pegasus.UI.Admin\Pages\BarangayMap.razor"
       
    List<BarangayModel> brgy = new List<BarangayModel>();
    List<PersonProfilesModel> persons = new List<PersonProfilesModel>();
    protected override async Task OnInitializedAsync()
    {
        await LoadBarangays();
        
    }

    async Task LoadBarangays()
    {
        brgy = await http.GetJsonAsync<List<BarangayModel>>("https://localhost:44399/api/Barangay");

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navmgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
