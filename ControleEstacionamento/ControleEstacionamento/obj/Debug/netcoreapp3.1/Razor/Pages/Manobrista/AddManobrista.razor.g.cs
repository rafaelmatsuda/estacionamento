#pragma checksum "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobrista\AddManobrista.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2af50c43829fae24ed4a7026ca78184a43a12109"
// <auto-generated/>
#pragma warning disable 1591
namespace ControleEstacionamento.Pages.Manobrista
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
#line 2 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobrista\AddManobrista.razor"
using ControleEstacionamento.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddManobrista")]
    public partial class AddManobrista : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Novo Manobrista</h3>\r\n<hr>\r\n\r\n");
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
            __builder.AddMarkupContent(12, "<label for=\"Nome\" class=\"control-label\">Nome</label>\r\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "form", "Nome");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobrista\AddManobrista.razor"
                                                                manobrista.Nome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => manobrista.Nome = __value, manobrista.Nome));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<label for=\"Cpf\" class=\"control-label\">CPF</label>\r\n                ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "form", "Cpf");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobrista\AddManobrista.razor"
                                                               manobrista.Cpf

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => manobrista.Cpf = __value, manobrista.Cpf));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.AddMarkupContent(34, "<label for=\"dtNascimento\" class=\"control-label\">Data Nascimento</label>\r\n                ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "form", "dtNascimento");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobrista\AddManobrista.razor"
                                                                        manobrista.DtNascimento

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => manobrista.DtNascimento = __value, manobrista.DtNascimento));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "row");
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col-md-4");
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group");
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "button");
            __builder.AddAttribute(55, "class", "btn btn-success");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobrista\AddManobrista.razor"
                                                                        CreateManobrista

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "value", "Salvar");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "type", "button");
            __builder.AddAttribute(61, "class", "btn btn-danger");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobrista\AddManobrista.razor"
                                                                       Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "value", "Cancelar");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\Rafa\Estudos\Estapar\ControleEstacionamento\ControleEstacionamento\Pages\Manobrista\AddManobrista.razor"
       
    Data.Manobrista manobrista = new Data.Manobrista();

    protected void CreateManobrista()
    {
        objManService.Create(manobrista);
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
