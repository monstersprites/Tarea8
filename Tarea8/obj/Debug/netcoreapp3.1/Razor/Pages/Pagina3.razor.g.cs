#pragma checksum "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Pages/Pagina3.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79acaed8361e01c70f32aca17a83be6095f84e1d"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea8.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/_Imports.razor"
using Tarea8;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/_Imports.razor"
using Tarea8.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pagina3")]
    public partial class Pagina3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"card rounded border border-primary\">\r\n<div class=\"card-head bg-primary\">\r\n<h3 class=\"text-center text-white\"><strong>Listado de vacunados por provincia</strong></h3>\r\n\r\n</div>\r\n</div>\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "class", "form-select");
            __builder.AddAttribute(3, "aria-label", "Default select example");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Pages/Pagina3.razor"
                                                                       provincia

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => provincia = __value, provincia));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "selected", true);
            __builder.AddContent(9, "Elija su provincia");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 13 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Pages/Pagina3.razor"
     foreach (var p in provincias)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "        ");
            __builder.OpenElement(12, "option");
            __builder.AddAttribute(13, "value", 
#nullable restore
#line 15 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Pages/Pagina3.razor"
                        p.NOMBRE

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, 
#nullable restore
#line 15 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Pages/Pagina3.razor"
                                   p.NOMBRE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 16 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Pages/Pagina3.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-light");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Pages/Pagina3.razor"
                                        listadoProvincia

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Listar");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table");
            __builder.AddMarkupContent(24, "\r\n\r\n    ");
            __builder.AddMarkupContent(25, "<tr>\r\n        <th>Cédula</th>\r\n        <th>Nombre</th>\r\n        <th>Apellido</th>\r\n        <th>Fecha P</th>\r\n        <th>Fecha S</th>\r\n    </tr>\r\n");
#nullable restore
#line 30 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Pages/Pagina3.razor"
     foreach (var a in resultados)
    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 34 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Pages/Pagina3.razor"
         a.CEDULA

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 35 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Pages/Pagina3.razor"
         a.NOMBRE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 36 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Pages/Pagina3.razor"
         a.APELLIDO

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 37 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Pages/Pagina3.razor"
         a.FECHA_P

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 38 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Pages/Pagina3.razor"
         a.FECHA_S

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 40 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Pages/Pagina3.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Pages/Pagina3.razor"
       

    protected override async Task OnInitializedAsync()
    {

        var api = "https://api-vacuna.herokuapp.com/api/Provinvias";
        WebClient cliente = new WebClient();
        var datos = await cliente.DownloadStringTaskAsync(api);
        provincias = JsonConvert.DeserializeObject<List<Root>>(datos);

    }

    List<Root> resultados = new List<Root>();
    string provincia;
    List<Root> provincias = new List<Root>();

    public void listadoProvincia()
    {

        var api = $"https://api-vacuna.herokuapp.com/api/List_Prov/{provincia}";
        WebClient cliente = new WebClient();
        var datos = cliente.DownloadString(api);
        resultados = JsonConvert.DeserializeObject<List<Root>>(datos);

    }


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Root
    {
        public string CEDULA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string FECHA_P { get; set; }
        public string FECHA_S { get; set; }
    }





#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
