#pragma checksum "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\Manobra.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddef9f07a595471c979408f83d86970407474cc2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
