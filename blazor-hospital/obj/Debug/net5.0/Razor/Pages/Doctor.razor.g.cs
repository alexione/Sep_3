#pragma checksum "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69834d06d7e675a8ffedcf3de05a4ac188e4f7f5"
// <auto-generated/>
#pragma warning disable 1591
namespace blazor_hospital.Pages
{
    #line hidden
    using System;
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
#line 11 "C:\Users\Manu\blazor-hospital\blazor-hospital\_Imports.razor"
using blazor_hospital.Models;

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
#line 3 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/doctor")]
    public partial class Doctor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Doctor</h3>");
#nullable restore
#line 11 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
 if (string.IsNullOrWhiteSpace(errorString) == false)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "h2");
            __builder.AddContent(3, 
#nullable restore
#line 13 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
                     errorString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
}
else if (forecast is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<div class=\"h4\">Loading...</div>");
#nullable restore
#line 18 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-striped");
            __builder.AddMarkupContent(7, @"<thead class=""thead-dark""><tr><th>CPR</th>
            <th>Name</th>
            <th>Age</th>
            <th>Speciality</th>
            <th>City</th>
            <th>Gender</th>
            <th>House Number</th>
            <th>Street</th>
            <th>Postal Code</th>
            <th>Phone</th></tr></thead>
        ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 38 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
         foreach (var w in forecast)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 41 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
                     w.cpr_doctor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 42 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
                     w.doctor_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 43 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
                     w.doctor_age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 44 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
                     w.speciality

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 45 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
                     w.city

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 46 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
                     w.gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 47 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
                     w.house_number

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 48 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
                     w.street

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 49 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
                     w.postal_code

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 50 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
                     w.phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\Doctor.razor"
       
    IList<DoctorModel> forecast;
    string errorString;

    protected override async Task OnInitializedAsync()
    {
        var request = new HttpRequestMessage(HttpMethod.Get,
            "https://localhost:8080/doctors");

        var client = _clientFactory.CreateClient("ServerName");

        HttpResponseMessage response = await client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
    //Console.WriteLine(response.Content.ReadAsStringAsync());
            string responseString = await response.Content.ReadAsStringAsync();
            forecast = JsonSerializer.Deserialize<List<DoctorModel>>(responseString);
            errorString = null;
        }
        else
        {
            errorString = $"There was an error getting our forecast: {response.ReasonPhrase}";
        }

    // var client = _clientFactory.CreateClient("meta");
    //
    // try
    // {
    //     forecast = await client.GetFromJsonAsync<DoctorModel>("http://localhost:8080/doctors");
    //     errorString = null;
    // }
    // catch (Exception ex)
    // {
    //     errorString = $"There was an error getting our forecast: { ex.Message }";
    // }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
    }
}
#pragma warning restore 1591