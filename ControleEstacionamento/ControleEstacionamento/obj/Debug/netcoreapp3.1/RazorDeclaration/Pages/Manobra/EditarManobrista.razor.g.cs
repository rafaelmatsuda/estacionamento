#pragma checksum "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\EditarManobrista.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c5869177fa2de1da3d5a2de5df9c7e5b947ae39"
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
#line 2 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\EditarManobrista.razor"
using ControleEstacionamento.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditarManobrista/{CurrentID}")]
    public partial class EditarManobrista : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobra\EditarManobrista.razor"
       
    [Parameter]
    public string CurrentID { get; set; }
    Data.Manobrista manobrista = new Data.Manobrista();

    protected override async Task OnInitializedAsync()
    {
        manobrista = await Task.Run(()=>objManService.GetManobristaById(Convert.ToInt32(CurrentID)));
    }

    protected void UpdateManobrista()
    {
        objManService.UpdateManobrista(manobrista);
        NavigationManager.NavigateTo("Manobrista");

    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Manobrista");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ManobristaService objManService { get; set; }
    }
}
#pragma warning restore 1591
