#pragma checksum "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\ContactedPerson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b7dc40b6fcb7face4745c7fac1cf6669858a44b"
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
#line 1 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\_Imports.razor"
using Pegasus.UI.Agent.PWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\_Imports.razor"
using Pegasus.UI.Agent.PWA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\_Imports.razor"
using Pegagus.UI.Agent.PWA.Maintenance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\_Imports.razor"
using Pegagus.UI.Agent.PWA.Profiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cases/contactedperson/{contactId:int}")]
    public partial class ContactedPerson : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<img class=\"avatar\" src=\"/image/peronicon.png\" alt=\"Avatar\">\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<label>Name :</label>\r\n    ");
            __builder.AddContent(4, 
#nullable restore
#line 11 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\ContactedPerson.razor"
     brgymodel.Fullname

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<label>Contact Number : </label> \r\n    ");
            __builder.AddContent(10, 
#nullable restore
#line 15 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\ContactedPerson.razor"
     brgymodel.Contact

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "class", "btn btn-success");
            __builder.AddAttribute(15, "href", "cases/createcontact/" + (
#nullable restore
#line 17 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\ContactedPerson.razor"
                                                      brgymodel.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Add New Contact");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n<br>\r\n");
#nullable restore
#line 19 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\ContactedPerson.razor"
 if (person == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.AddMarkupContent(19, "<p><em>Loading...</em></p> ");
#nullable restore
#line 21 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\ContactedPerson.razor"
                               }
else
{



#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "    ");
            __builder.OpenElement(21, "table");
            __builder.AddAttribute(22, "class", "table");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddMarkupContent(24, "<thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Barangay</th>\r\n                <th>Status</th>\r\n\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(25, "tbody");
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 36 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\ContactedPerson.razor"
             foreach (var per in person)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                ");
            __builder.OpenElement(28, "tr");
            __builder.AddMarkupContent(29, "\r\n\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 40 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\ContactedPerson.razor"
                         per.Fullname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 41 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\ContactedPerson.razor"
                         per.Barangay.BarangayName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 42 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\ContactedPerson.razor"
                         per.PersonStatus

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 43 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\ContactedPerson.razor"
                         per.QrCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 46 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\ContactedPerson.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 49 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\ContactedPerson.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\ContactedPerson.razor"
       

    List<PersonProfilesModel> person = new List<PersonProfilesModel>();

    [Parameter] public int contactId { get; set; }

    PersonProfilesModel brgymodel = new PersonProfilesModel();

    protected async override Task OnParametersSetAsync()
    {
        brgymodel = await http.GetFromJsonAsync<PersonProfilesModel>($"https://localhost:44326/api/Person/" + contactId);
    }
    protected override async Task OnInitializedAsync()
    {
        await LoadContactedPerson();
    }

    async Task LoadContactedPerson()
    {
        person = await http.GetFromJsonAsync<List<PersonProfilesModel>>("https://localhost:44326/api/Contacts/" + contactId);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navmgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
