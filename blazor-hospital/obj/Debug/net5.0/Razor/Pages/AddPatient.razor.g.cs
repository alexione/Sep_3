#pragma checksum "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efbe370ac719a83f1fecc8cc05fd794f6d100a85"
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
#line 4 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addpatient")]
    public partial class AddPatient : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 14 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
 if (string.IsNullOrWhiteSpace(errorString) == false)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "h2");
            __builder.AddContent(2, 
#nullable restore
#line 16 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                     errorString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
}
else if (rooms is null || doctors is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<div class=\"h4\">Loading...</div>");
#nullable restore
#line 21 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "<h4 class=\"card-header\">Add Patient</h4>\r\n\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 28 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                          patient

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 28 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                                                  OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(17, "<label for=\"inputCpr\">Cpr number</label>\r\n                ");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "type", "text");
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "id", "inputCpr");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                                                                                   patient.cpr_patient

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.cpr_patient = __value, patient.cpr_patient));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(27, "<label for=\"inputName\">Name</label>\r\n                ");
                __builder2.OpenElement(28, "input");
                __builder2.AddAttribute(29, "type", "text");
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "id", "inputName");
                __builder2.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                                                                                    patient.patient_name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.patient_name = __value, patient.patient_name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n            \r\n            ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(37, "<label for=\"inputblood_type\">Blood Type</label>\r\n                ");
                __builder2.OpenElement(38, "input");
                __builder2.AddAttribute(39, "type", "text");
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "id", "inputblood_type");
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                                                                                          patient.blood_type

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.blood_type = __value, patient.blood_type));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n            \r\n            ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(47, "<label for=\"inputhouse_number\">House Number</label>\r\n                ");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "type", "text");
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "id", "inputhouse_number");
                __builder2.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                                                                                            patient.house_number

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.house_number = __value, patient.house_number));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n            \r\n            ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(57, "<label for=\"inputstreet\">Street</label>\r\n                ");
                __builder2.OpenElement(58, "input");
                __builder2.AddAttribute(59, "type", "text");
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "id", "inputstreet");
                __builder2.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                                                                                      patient.street

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.street = __value, patient.street));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n            \r\n            ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(67, "<label for=\"inputpostal_code\">Postal Code</label>\r\n                ");
                __builder2.OpenElement(68, "input");
                __builder2.AddAttribute(69, "type", "text");
                __builder2.AddAttribute(70, "class", "form-control");
                __builder2.AddAttribute(71, "id", "inputpostal_code");
                __builder2.AddAttribute(72, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                                                                                           patient.postal_code

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.postal_code = __value, patient.postal_code));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n            \r\n            ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(77, "<label for=\"inputcity\">City</label>\r\n                ");
                __builder2.OpenElement(78, "input");
                __builder2.AddAttribute(79, "type", "text");
                __builder2.AddAttribute(80, "class", "form-control");
                __builder2.AddAttribute(81, "id", "inputcity");
                __builder2.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                                                                                    patient.city

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.city = __value, patient.city));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n            \r\n            ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(87, "<label for=\"inputphone\">Phone</label>\r\n                ");
                __builder2.OpenElement(88, "input");
                __builder2.AddAttribute(89, "type", "text");
                __builder2.AddAttribute(90, "class", "form-control");
                __builder2.AddAttribute(91, "id", "inputphone");
                __builder2.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                                                                                     patient.phone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.phone = __value, patient.phone));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n            \r\n            ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(97, "<label for=\"inputgender\">Gender</label>\r\n                          ");
                __builder2.OpenElement(98, "select");
                __builder2.AddAttribute(99, "name", "inputgender");
                __builder2.AddAttribute(100, "id", "inputgender");
                __builder2.AddAttribute(101, "class", "form-control");
                __builder2.AddAttribute(102, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 86 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                                                                                                 patient.gender

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(103, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.gender = __value, patient.gender));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(104, "option");
                __builder2.AddAttribute(105, "value");
                __builder2.AddContent(106, "-- Select Department --");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n                              ");
                __builder2.OpenElement(108, "option");
                __builder2.AddAttribute(109, "value", "M");
                __builder2.AddContent(110, "M");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n                                ");
                __builder2.OpenElement(112, "option");
                __builder2.AddAttribute(113, "value", "F");
                __builder2.AddContent(114, "F");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n                                ");
                __builder2.OpenElement(116, "option");
                __builder2.AddAttribute(117, "value", "No Gender");
                __builder2.AddContent(118, "No Gender");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n                      \r\n                        \r\n            \r\n              ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(122, "<label for=\"inputlast_update\">Last Update</label>\r\n                            ");
                __builder2.OpenElement(123, "input");
                __builder2.AddAttribute(124, "type", "text");
                __builder2.AddAttribute(125, "class", "form-control");
                __builder2.AddAttribute(126, "id", "inputlast_update");
                __builder2.AddAttribute(127, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 99 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                                                                                                       patient.last_update

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(128, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.last_update = __value, patient.last_update));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                        \r\n            \r\n            ");
                __builder2.OpenElement(130, "div");
                __builder2.AddAttribute(131, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(132, "<label for=\"inputpatient_status\">Patient Status</label>\r\n                ");
                __builder2.OpenElement(133, "input");
                __builder2.AddAttribute(134, "type", "text");
                __builder2.AddAttribute(135, "class", "form-control");
                __builder2.AddAttribute(136, "id", "inputpatient_status");
                __builder2.AddAttribute(137, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 106 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                                                                                              patient.patient_status

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(138, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.patient_status = __value, patient.patient_status));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n            \r\n       \r\n            \r\n              \r\n            ");
                __builder2.OpenElement(140, "div");
                __builder2.AddAttribute(141, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(142, "<label for=\"roomID\">Room</label>\r\n                ");
                __builder2.OpenElement(143, "select");
                __builder2.AddAttribute(144, "name", "roomID");
                __builder2.AddAttribute(145, "id", "roomID");
                __builder2.AddAttribute(146, "class", "form-control");
                __builder2.AddAttribute(147, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 122 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                                                                             patient.roomID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(148, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.roomID = __value, patient.roomID));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(149, "option");
                __builder2.AddAttribute(150, "value");
                __builder2.AddContent(151, "-- Select Department --");
                __builder2.CloseElement();
#nullable restore
#line 124 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                     foreach (var w in rooms)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(152, "option");
                __builder2.AddAttribute(153, "value", 
#nullable restore
#line 126 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                                        w.room_number

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(154, 
#nullable restore
#line 127 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                             w.room_number

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 129 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(155, "\r\n            \r\n            \r\n            \r\n            ");
                __builder2.OpenElement(156, "div");
                __builder2.AddAttribute(157, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(158, "<label for=\"doctorId\">Doctor</label>\r\n                ");
                __builder2.OpenElement(159, "select");
                __builder2.AddAttribute(160, "name", "doctorId");
                __builder2.AddAttribute(161, "id", "doctorId");
                __builder2.AddAttribute(162, "class", "form-control");
                __builder2.AddAttribute(163, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 142 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                                                                                 patient.doctorId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(164, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient.doctorId = __value, patient.doctorId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(165, "option");
                __builder2.AddAttribute(166, "value");
                __builder2.AddContent(167, "-- Select Department --");
                __builder2.CloseElement();
#nullable restore
#line 144 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                     foreach (var w in doctors)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(168, "option");
                __builder2.AddAttribute(169, "value", 
#nullable restore
#line 146 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                                        w.cpr_doctor

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(170, 
#nullable restore
#line 147 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                             w.doctor_name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 149 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(171, "\r\n                        \r\n            \r\n                        \r\n            \r\n\r\n\r\n            ");
                __builder2.OpenElement(172, "button");
                __builder2.AddAttribute(173, "disabled", 
#nullable restore
#line 158 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                               loading

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(174, "class", "btn btn-primary");
#nullable restore
#line 159 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                 if (loading)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(175, "<span class=\"spinner-border spinner-border-sm mr-1\"></span>");
#nullable restore
#line 162 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(176, "                Save\r\n            ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 254 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
 
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 173 "C:\Users\Manu\blazor-hospital\blazor-hospital\Pages\AddPatient.razor"
       

    PatientMod patient = new PatientMod();
    private bool loading;
    //string companyname = requForm["companyname"];

    protected async Task OnValidSubmit()
    {
        loading = true;
        try
        {
            var client = _clientFactory.CreateClient("ServerName");
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:8080/patients"),
                Content = new StringContent("{\n\t\"cpr_patient\":" + patient.cpr_patient + ",\n\t\"patient_name\":\"" + patient.patient_name + "\",\n\t\"blood_type\":\"" + patient.blood_type + "\",\n\t\"house_number\":" + patient.house_number + ",\n\t\"street\":\"" + patient.street + "\",\n\t\"postal_code\":" + patient.postal_code + ",\n\t\"city\":\"" + patient.city + "\",\n\t\"phone\":" + patient.phone + ",\n\t\"gender\":\"" + patient.gender + "\",\n\t\"last_update\":\"" + patient.last_update + "\",\n\t\"patient_status\":\"" + patient.patient_status + "\",\n\t\"doctorId\":" + patient.doctorId + ",\n\t\"roomID\": " + patient.roomID + "\n}\n")
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                NavigationManager.NavigateTo("/");
            }
        }
        catch (Exception ex)
        {
        }
    }


    IList<RoomModel> rooms;
    IList<DoctorModel> doctors;
    string errorString;

    protected override async Task OnInitializedAsync()
    {
        var request = new HttpRequestMessage(HttpMethod.Get,
            "https://localhost:8080/rooms");
        var request2 = new HttpRequestMessage(HttpMethod.Get,
            "https://localhost:8080/doctors");

        var client = _clientFactory.CreateClient("ServerName");

        HttpResponseMessage response = await client.SendAsync(request);
        HttpResponseMessage response2 = await client.SendAsync(request2);
        if (response.IsSuccessStatusCode && response2.IsSuccessStatusCode)
        {
    //Console.WriteLine(response.Content.ReadAsStringAsync());
            string responseString = await response.Content.ReadAsStringAsync();
            rooms = JsonSerializer.Deserialize<List<RoomModel>>(responseString);
            string responseString2 = await response2.Content.ReadAsStringAsync();
            doctors = JsonSerializer.Deserialize<List<DoctorModel>>(responseString2);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
    }
}
#pragma warning restore 1591
