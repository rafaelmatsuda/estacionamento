#pragma checksum "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Veiculo\EditarVeiculo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29bd3bf8dd9629482bd585a70d4c3c62a61a6d2a"
// <auto-generated/>
#pragma warning disable 1591
namespace ControleEstacionamento.Pages.Veiculo
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
#line 2 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Veiculo\EditarVeiculo.razor"
using ControleEstacionamento.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditarVeiculo/{CurrentID}")]
    public partial class EditarVeiculo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar Veiculo</h3>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "for", "Name");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Veiculo\EditarVeiculo.razor"
                                                               veiculo.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => veiculo.Id = __value, veiculo.Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.AddMarkupContent(22, "<label for=\"Marca\" class=\"control-label\">Marca</label>\r\n                ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "form", "Marca");
            __builder.AddAttribute(25, "class", "form-control");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Veiculo\EditarVeiculo.razor"
                                                                 veiculo.Marca

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => veiculo.Marca = __value, veiculo.Marca));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group");
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.AddMarkupContent(33, "<label for=\"Modelo\" class=\"control-label\">Modelo</label>\r\n                ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "form", "Modelo");
            __builder.AddAttribute(36, "class", "form-control");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Veiculo\EditarVeiculo.razor"
                                                                  veiculo.Modelo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => veiculo.Modelo = __value, veiculo.Modelo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-group");
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.AddMarkupContent(44, "<label for=\"Placa\" class=\"control-label\">Placa</label>\r\n                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "form", "Placa");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Veiculo\EditarVeiculo.razor"
                                                                 veiculo.Placa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => veiculo.Placa = __value, veiculo.Placa));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "row");
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "col-md-4");
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "form-group");
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "button");
            __builder.AddAttribute(65, "class", "btn btn-success");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Veiculo\EditarVeiculo.razor"
                                                                        UpdateVeiculo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "value", "Atualizar");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.OpenElement(69, "input");
            __builder.AddAttribute(70, "type", "button");
            __builder.AddAttribute(71, "class", "btn btn-danger");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Veiculo\EditarVeiculo.razor"
                                                                       Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "value", "Cancelar");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Veiculo\EditarVeiculo.razor"
       
    [Parameter]
    public string CurrentID { get; set; }
    Data.Veiculo veiculo = new Data.Veiculo();

    protected override async Task OnInitializedAsync()
    {
        veiculo = await Task.Run(()=>objManService.GetVeiculoById(Convert.ToInt32(CurrentID)));
    }

    protected void UpdateVeiculo()
    {
        objManService.UpdateVeiculo(veiculo);
        NavigationManager.NavigateTo("Veiculo");

    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Veiculo");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VeiculoService objManService { get; set; }
    }
}
#pragma warning restore 1591
