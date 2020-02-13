#pragma checksum "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\Manobra.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddef9f07a595471c979408f83d86970407474cc2"
// <auto-generated/>
#pragma warning disable 1591
namespace ControleEstacionamento.Pages.Manobra
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\_Imports.razor"
using ControleEstacionamento;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\_Imports.razor"
using ControleEstacionamento.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\Manobra.razor"
using ControleEstacionamento.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/manobra")]
    public partial class Manobra : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Registro de Manobra</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "nav-link");
            __builder.AddAttribute(3, "href", "AddManobra");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Nova Manobra\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
#nullable restore
#line 11 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\Manobra.razor"
 if (objManobra == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<p><em>Carregando Manobras ...</em></p>\r\n");
#nullable restore
#line 14 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\Manobra.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddMarkupContent(13, @"<thead>
            <tr>
                <th>Marca</th>
                <th>Modelo</th>
                <th>Placa</th>
                <th>Manobrista</th>
                <th>Data</th>
                <th>Ação</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 29 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\Manobra.razor"
             foreach (var manobra in objManobra)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 32 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\Manobra.razor"
                         manobra.Veiculo.Marca

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 33 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\Manobra.razor"
                         manobra.Veiculo.Modelo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 34 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\Manobra.razor"
                         manobra.Veiculo.Placa

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 35 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\Manobra.razor"
                         manobra.Manobrista.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 36 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\Manobra.razor"
                         manobra.DataManobra

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "td");
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "class", "nav-link");
            __builder.AddAttribute(38, "href", "EditarManobra/" + (
#nullable restore
#line 38 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\Manobra.razor"
                                                                 manobra.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(39, "\r\n                            <span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>Editar\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "class", "nav-link");
            __builder.AddAttribute(43, "href", "RemoverManobra/" + (
#nullable restore
#line 41 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\Manobra.razor"
                                                                  manobra.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "\r\n                            <span class=\"oi oi-trash\" aria-hidden=\"true\"></span>Remover\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 46 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\Manobra.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 49 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\Manobra.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\Manobra.razor"
       
    List<Data.RegistroManobra> objManobra;

    protected override async Task OnInitializedAsync()
    {
        objManobra = await Task.Run(() => objService.GetRegistroManobras());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RegistroManobraService objService { get; set; }
    }
}
#pragma warning restore 1591
