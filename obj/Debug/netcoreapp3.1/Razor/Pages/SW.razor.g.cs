#pragma checksum "C:\Users\mmucci001\source\repos\ToDoList\Pages\SW.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77677cf96dd0aaf2be3f244fd6476cd9f85936ec"
// <auto-generated/>
#pragma warning disable 1591
namespace ToDoList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mmucci001\source\repos\ToDoList\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mmucci001\source\repos\ToDoList\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mmucci001\source\repos\ToDoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mmucci001\source\repos\ToDoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mmucci001\source\repos\ToDoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mmucci001\source\repos\ToDoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mmucci001\source\repos\ToDoList\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mmucci001\source\repos\ToDoList\_Imports.razor"
using ToDoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mmucci001\source\repos\ToDoList\_Imports.razor"
using ToDoList.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sw")]
    public partial class SW : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Here is a list of SW characters</h2>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>From Tatooine:</p>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\mmucci001\source\repos\ToDoList\Pages\SW.razor"
 if (_characters.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<div>There are characters</div>\r\n");
#nullable restore
#line 12 "C:\Users\mmucci001\source\repos\ToDoList\Pages\SW.razor"
     foreach (var character in _characters)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "div");
            __builder.AddContent(6, 
#nullable restore
#line 14 "C:\Users\mmucci001\source\repos\ToDoList\Pages\SW.razor"
              character.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 15 "C:\Users\mmucci001\source\repos\ToDoList\Pages\SW.razor"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mmucci001\source\repos\ToDoList\Pages\SW.razor"
     
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "    ");
            __builder.AddMarkupContent(9, "<div>No characters</div>\r\n");
#nullable restore
#line 21 "C:\Users\mmucci001\source\repos\ToDoList\Pages\SW.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\mmucci001\source\repos\ToDoList\Pages\SW.razor"
 
    private List<Character> _characters = new List<Character>();
    protected override async Task OnInitializedAsync() => await GetCharacters();
    private async Task GetCharacters() => _characters = await httpClient.GetJsonAsync<List<Character>>("http://swapi.dev/api/people/1");
        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
