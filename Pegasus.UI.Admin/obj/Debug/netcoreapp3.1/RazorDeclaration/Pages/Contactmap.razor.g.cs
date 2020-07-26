#pragma checksum "C:\Users\Hagutin\Documents\GitHub\PandemicWatch\Pegasus.UI.Admin\Pages\Contactmap.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ea96106bc111406556228fe9099b6eec381e00d"
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
#line 1 "C:\Users\Hagutin\Documents\GitHub\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hagutin\Documents\GitHub\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hagutin\Documents\GitHub\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hagutin\Documents\GitHub\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hagutin\Documents\GitHub\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hagutin\Documents\GitHub\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hagutin\Documents\GitHub\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hagutin\Documents\GitHub\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Pegasus.UI.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hagutin\Documents\GitHub\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Pegasus.UI.Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Hagutin\Documents\GitHub\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Pegasus.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Hagutin\Documents\GitHub\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Hagutin\Documents\GitHub\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Hagutin\Documents\GitHub\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Pegasus.Models.Maintenance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Hagutin\Documents\GitHub\PandemicWatch\Pegasus.UI.Admin\_Imports.razor"
using Pegasus.Models.Profiles;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/personmap/{personId:int}")]
    public partial class Contactmap : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\Hagutin\Documents\GitHub\PandemicWatch\Pegasus.UI.Admin\Pages\Contactmap.razor"
      
    [Parameter] public int personId { get; set; }
    List<PersonProfilesModel> contactpersonsmodel = new List<PersonProfilesModel>();
    PersonProfilesModel principalpersonsmodel = new PersonProfilesModel();
    PersonProfilesModel secondperson = new PersonProfilesModel();
    List<PersonProfilesModel> allpersonsmodel = new List<PersonProfilesModel>();

    protected async override Task OnParametersSetAsync()
    {
        contactpersonsmodel = await http.GetJsonAsync<List<PersonProfilesModel>>($"https://pegasusapiadmin.azurewebsites.net/api/Contacts/" + personId);
        principalpersonsmodel = await http.GetJsonAsync<PersonProfilesModel>($"https://pegasusapiadmin.azurewebsites.net/api/Person/" + personId);
        allpersonsmodel = await http.GetJsonAsync<List<PersonProfilesModel>>($"https://pegasusapiadmin.azurewebsites.net/api/Person/");
    }

     void GetSecondLevel(int id)
    {
        secondperson = allpersonsmodel.FirstOrDefault(x => x.PrincipalPersonId == id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navmgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
