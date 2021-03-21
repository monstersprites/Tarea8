#pragma checksum "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\Pages\Pagina1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad74ba66a711ae687f1cdfa391436c6284c2ead4"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea8.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\_Imports.razor"
using Tarea8;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\_Imports.razor"
using Tarea8.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\Pages\Pagina1.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pagina1")]
    public partial class Pagina1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\Pages\Pagina1.razor"
       

    protected override async Task OnInitializedAsync()
    {

        var api1 = "https://api-vacuna.herokuapp.com/api/Provinvias";
        var api2 = "https://api-vacuna.herokuapp.com/api/Vacunas";
        WebClient cliente = new WebClient();
        var datos1 = cliente.DownloadString(api1);
        var datos2 = cliente.DownloadString(api2);
        provincias = JsonConvert.DeserializeObject<List<Root>>(datos1);
        vacunas = JsonConvert.DeserializeObject<List<Root>>(datos2);

    }

    string cedula, vacuna, provincia;
    DateTime fecha;
    Root resultado;
    List<Root> provincias = new List<Root>();
    List<Root> vacunas = new List<Root>();
    string API;

    public void registrarVacuna()
    {
        //provincia = provincia.Replace(" ", "%20");
        string dia = fecha.Day.ToString();
        string mes = fecha.Month.ToString();
        string year = fecha.Year.ToString();
        API = $"https://api-vacuna.herokuapp.com/api/Registrar_P/" + cedula + "/" + vacuna + "/" + provincia + "/" + dia + "-" + mes + "-" + year;
        WebClient cliente = new WebClient();
        var post = cliente.DownloadString(API);
        resultado = JsonConvert.DeserializeObject<Root>(post);
    }


    public class Root
    {

        public string mensaje { get; set; }
        public string NOMBRE { get; set; } //Provincia
        public string MARCA { get; set; } //Vacuna

    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
