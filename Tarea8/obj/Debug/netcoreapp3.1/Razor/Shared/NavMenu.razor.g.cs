#pragma checksum "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26a85ffbf8bf79fd489365fc638fbb465046132b"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea8.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a style=\"font-size: 14px;\" class=\"navbar-brand text-center\" href><strong>SISTEMA DE CONTROL DE <br>VACUNAS</strong></a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Shared/NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 9 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Shared/NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Shared/NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 12 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Shared/NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Inicio\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n        ");
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "nav-item px-3");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "mapa");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Mapa\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "li");
            __builder.AddAttribute(39, "class", "nav-item px-3");
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
            __builder.AddAttribute(42, "class", "nav-link");
            __builder.AddAttribute(43, "href", "Pagina1");
            __builder.AddAttribute(44, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 23 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Shared/NavMenu.razor"
                                                            NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(46, "\r\n                <span class=\"iconify\" data-icon=\"codicon:save-as\" data-inline=\"false\"></span>Registrar\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "li");
            __builder.AddAttribute(50, "class", "nav-item px-3");
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(52);
            __builder.AddAttribute(53, "class", "nav-link");
            __builder.AddAttribute(54, "href", "Pagina2");
            __builder.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(56, "\r\n                <span class=\"iconify\" data-icon=\"ant-design:search-outlined\" data-inline=\"false\"></span> Consulta Vacunados\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.OpenElement(59, "li");
            __builder.AddAttribute(60, "class", "nav-item px-3");
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(62);
            __builder.AddAttribute(63, "class", "nav-link");
            __builder.AddAttribute(64, "href", "Pagina3");
            __builder.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(66, "\r\n                <span class=\"iconify\" data-icon=\"fa-solid:th-list\" data-inline=\"false\"></span>Lista Vacunados\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.OpenElement(69, "li");
            __builder.AddAttribute(70, "class", "nav-item px-3");
            __builder.AddAttribute(71, "style", "font-size: 10px;");
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(73);
            __builder.AddAttribute(74, "class", "nav-link");
            __builder.AddAttribute(75, "href", "Pagina4");
            __builder.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(77, "\r\n                <span class=\"iconify\" data-icon=\"fa-solid:th-list\" data-inline=\"false\"></span>Lista Vacunados por Marca\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.OpenElement(80, "li");
            __builder.AddAttribute(81, "class", "nav-item px-3");
            __builder.AddAttribute(82, "style", "font-size: 10px;");
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(84);
            __builder.AddAttribute(85, "class", "nav-link");
            __builder.AddAttribute(86, "href", "Pagina5");
            __builder.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(88, "\r\n                <span class=\"iconify\" data-icon=\"fa-solid:th-list\" data-inline=\"false\"></span>Listado de vacunados por signo\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(89, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.OpenElement(91, "li");
            __builder.AddAttribute(92, "class", "nav-item px-3");
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(94);
            __builder.AddAttribute(95, "class", "nav-link");
            __builder.AddAttribute(96, "href", "Pagina6");
            __builder.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(98, "\r\n                <span class=\"iconify\" data-icon=\"ant-design:close-square-filled\" data-inline=\"false\"></span> Anular Registros\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(99, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n            \r\n                ");
            __builder.OpenElement(101, "li");
            __builder.AddAttribute(102, "class", "nav-item px-3");
            __builder.AddMarkupContent(103, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(104);
            __builder.AddAttribute(105, "class", "nav-link");
            __builder.AddAttribute(106, "href", "Pagina7");
            __builder.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(108, "\r\n                <span class=\"iconify\" data-icon=\"vscode-icons:file-type-light-config\" data-inline=\"false\"></span>Configuracion\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(109, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "/home/elmer/Desktop/tareas_de_p3/Tarea8/Tarea8/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
