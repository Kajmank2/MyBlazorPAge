#pragma checksum "C:\Users\Len\Desktop\MyBlazorPAge\BlazorApplication\Data\TodosItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40c9bba43f64433acad121af51d10f9bbdad6ac9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApplication.Data
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Len\Desktop\MyBlazorPAge\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Len\Desktop\MyBlazorPAge\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Len\Desktop\MyBlazorPAge\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Len\Desktop\MyBlazorPAge\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Len\Desktop\MyBlazorPAge\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Len\Desktop\MyBlazorPAge\BlazorApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Len\Desktop\MyBlazorPAge\BlazorApplication\_Imports.razor"
using BlazorApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Len\Desktop\MyBlazorPAge\BlazorApplication\_Imports.razor"
using BlazorApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Len\Desktop\MyBlazorPAge\BlazorApplication\Data\TodosItem.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/api/TodoItems")]
    public partial class TodosItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "placeholder", "New Todo Item");
            __builder.AddAttribute(2, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\Users\Len\Desktop\MyBlazorPAge\BlazorApplication\Data\TodosItem.razor"
              _newItemName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newItemName = __value, _newItemName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Len\Desktop\MyBlazorPAge\BlazorApplication\Data\TodosItem.razor"
                   AddItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Add");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Len\Desktop\MyBlazorPAge\BlazorApplication\Data\TodosItem.razor"
       
    private string _newItemName;

    private async Task AddItem()
    {
        var addItem = new TodoItem { Name = _newItemName, IsComplete = false };
        await Http.PostAsJsonAsync("api/TodoItems", addItem);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591