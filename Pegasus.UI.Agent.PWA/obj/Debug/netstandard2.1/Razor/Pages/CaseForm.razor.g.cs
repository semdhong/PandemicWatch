#pragma checksum "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "947dcf9a82a1239499590e98e988044bdfdba6d8"
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
    public partial class CaseForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor"
                      Person

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor"
                                             OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n\r\n\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.AddMarkupContent(10, "<label>Name</label>\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddMarkupContent(12, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "col-md-4 form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor"
                                                                       Person.Fullname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Person.Fullname = __value, Person.Fullname))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Person.Fullname));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                ");
                __Blazor.Pegasus.UI.Agent.PWA.Pages.CaseForm.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 15 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor"
                                          () => Person.Fullname

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.AddMarkupContent(24, "<label>Barangay</label>\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.OpenElement(30, "select");
                __builder2.AddAttribute(31, "class", "col-md-4 form-control");
                __builder2.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor"
                                                              Person.BgryId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Person.BgryId = __value, Person.BgryId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(34, "\r\n");
#nullable restore
#line 22 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor"
                     if (brgyprofile != null)
                    {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor"
     foreach (var lgu in brgyprofile)
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(35, "    ");
                __builder2.OpenElement(36, "option");
                __builder2.AddAttribute(37, "value", 
#nullable restore
#line 26 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor"
                    lgu.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(38, 
#nullable restore
#line 26 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor"
                             lgu.BarangayName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(39, "                    ");
#nullable restore
#line 26 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor"
                                                                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor"
                                                                           }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(40, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.AddMarkupContent(47, "<label>Address</label>\r\n            ");
                __builder2.OpenElement(48, "div");
                __builder2.AddMarkupContent(49, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "class", "col-md-4 form-control");
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor"
                                                                       Person.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Person.Address = __value, Person.Address))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Person.Address));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n                ");
                __Blazor.Pegasus.UI.Agent.PWA.Pages.CaseForm.TypeInference.CreateValidationMessage_1(__builder2, 56, 57, 
#nullable restore
#line 34 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor"
                                          () => Person.Address

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group");
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.AddMarkupContent(64, "<label>Contact Number</label>\r\n            ");
                __builder2.OpenElement(65, "div");
                __builder2.AddMarkupContent(66, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(67);
                __builder2.AddAttribute(68, "class", "col-md-4 form-control");
                __builder2.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor"
                                                                       Person.Contact

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Person.Contact = __value, Person.Contact))));
                __builder2.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Person.Contact));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n                ");
                __Blazor.Pegasus.UI.Agent.PWA.Pages.CaseForm.TypeInference.CreateValidationMessage_2(__builder2, 73, 74, 
#nullable restore
#line 41 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor"
                                          () => Person.Contact

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(75, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "form-group");
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.OpenElement(81, "button");
                __builder2.AddAttribute(82, "type", "submit");
                __builder2.AddAttribute(83, "class", "btn btn-dark");
                __builder2.AddMarkupContent(84, "\r\n                ");
                __builder2.AddContent(85, 
#nullable restore
#line 46 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor"
                 ButtonText

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(86, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\semdhong\Documents\GitHub\PEGASUS\Pegasus.UI.Agent.PWA\Pages\CaseForm.razor"
        
    [Parameter] public PersonProfilesModel Person { get; set; }
    [Parameter] public string ButtonText { get; set; } = "Save";
    [Parameter] public EventCallback OnValidSubmit { get; set; }

    List<BarangayModel> brgyprofile { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await LoadLguProfile();
    }

    async Task LoadLguProfile()
    {
        brgyprofile = await http.GetFromJsonAsync<List<BarangayModel>>("https://localhost:44399/api/Barangay");
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.Pegasus.UI.Agent.PWA.Pages.CaseForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
