#pragma checksum "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fbb048149b18b9d0d033a370acc058fccf3d166"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Manu\blazor-hospital\blazor-hospital\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Manu\blazor-hospital\blazor-hospital\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Manu\blazor-hospital\blazor-hospital\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Manu\blazor-hospital\blazor-hospital\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Manu\blazor-hospital\blazor-hospital\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Manu\blazor-hospital\blazor-hospital\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Manu\blazor-hospital\blazor-hospital\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Manu\blazor-hospital\blazor-hospital\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Manu\blazor-hospital\blazor-hospital\_Imports.razor"
using blazor_hospital;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Manu\blazor-hospital\blazor-hospital\_Imports.razor"
using blazor_hospital.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Manu\blazor-hospital\blazor-hospital\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Login.razor"
using blazor_hospital.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Login.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Login.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Login.razor"
using blazor_hospital.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 35 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Login.razor"
 if (string.IsNullOrWhiteSpace(errorString) == false)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "h2");
            __builder.AddContent(2, 
#nullable restore
#line 37 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Login.razor"
                     errorString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Login.razor"
}
else if (users is null )
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<div class=\"h4\">Loading...</div>");
#nullable restore
#line 42 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Login.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "<h4 class=\"card-header\">Login</h4>\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "<label>Username</label>\r\n            ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "placeholder", "user name");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Login.razor"
                                                                    users

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => users = __value, users));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "form-group");
            __builder.AddMarkupContent(20, "<label>Password</label>\r\n            ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "password");
            __builder.AddAttribute(23, "placeholder", "password");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Login.razor"
                                                                       users

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => users = __value, users));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", "");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Login.razor"
                             PerformLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "\r\n            Login\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 103 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Login.razor"
 
    /*
    public async Task PerformLogout() {
        errorMessage = "";
        username = "";
        password = "";
        try {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        } catch (Exception e) { }
    }
    */

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Login.razor"
       
  
    IList<User> users;
    string errorString;
    private string username;
    private string password;
    
    
    public async Task PerformLogin() {
        errorString = "";
        try {
            
            var client = _clientFactory.CreateClient("ServerName");
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:8080/patients/" + users.Count),
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
                username = "";
                password = "";
             
            }
        }
        catch (Exception ex)
        {
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
