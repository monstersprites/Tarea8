#pragma checksum "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\Pages\Pagina2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0454a6a39e1b608406fe17d08d967c61486650b"
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
#line 10 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\_Imports.razor"
using Newtonsoft.Json;

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/pagina2")]
    public partial class Pagina2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\Tarea8\Pages\Pagina2.razor"
       

    Root resultados = null;
    string filtro;
    string busqueda;

    public void buscarFiltro()
    {
        var api = $"https://api-vacuna.herokuapp.com/api/Consultar_V/{filtro}/{busqueda}";
        WebClient cliente = new WebClient();
        var datos = cliente.DownloadString(api);
        resultados = JsonConvert.DeserializeObject<Root>(datos);
    }

    public class Root
    {
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public int DOSIS { get; set; }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
