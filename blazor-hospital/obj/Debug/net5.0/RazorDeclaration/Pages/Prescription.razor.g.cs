// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazor_hospital.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ionut\Desktop\blazor-hospital\blazor-hospital\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ionut\Desktop\blazor-hospital\blazor-hospital\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ionut\Desktop\blazor-hospital\blazor-hospital\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ionut\Desktop\blazor-hospital\blazor-hospital\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ionut\Desktop\blazor-hospital\blazor-hospital\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ionut\Desktop\blazor-hospital\blazor-hospital\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ionut\Desktop\blazor-hospital\blazor-hospital\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ionut\Desktop\blazor-hospital\blazor-hospital\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ionut\Desktop\blazor-hospital\blazor-hospital\_Imports.razor"
using blazor_hospital;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ionut\Desktop\blazor-hospital\blazor-hospital\_Imports.razor"
using blazor_hospital.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ionut\Desktop\blazor-hospital\blazor-hospital\_Imports.razor"
using blazor_hospital.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ionut\Desktop\blazor-hospital\blazor-hospital\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ionut\Desktop\blazor-hospital\blazor-hospital\Pages\Prescription.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ionut\Desktop\blazor-hospital\blazor-hospital\Pages\Prescription.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ionut\Desktop\blazor-hospital\blazor-hospital\Pages\Prescription.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ionut\Desktop\blazor-hospital\blazor-hospital\Pages\Prescription.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/prescription")]
    public partial class Prescription : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Ionut\Desktop\blazor-hospital\blazor-hospital\Pages\Prescription.razor"
       
    IList<PrescriptionModel> forecast;
    string errorString;

    protected override async Task OnInitializedAsync()
    {
        var request = new HttpRequestMessage(HttpMethod.Get,
            "https://localhost:8080/prescriptions");

        var client = _clientFactory.CreateClient("ServerName");

        HttpResponseMessage response = await client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
    //Console.WriteLine(response.Content.ReadAsStringAsync());
            string responseString = await response.Content.ReadAsStringAsync();
            forecast = JsonSerializer.Deserialize<List<PrescriptionModel>>(responseString);
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
