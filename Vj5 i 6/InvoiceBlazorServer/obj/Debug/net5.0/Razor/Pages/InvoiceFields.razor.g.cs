#pragma checksum "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85e8dbd59d9029fbfd3fb1dbcca67dce3e457d23"
// <auto-generated/>
#pragma warning disable 1591
namespace InvoiceBlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\_Imports.razor"
using InvoiceBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\_Imports.razor"
using InvoiceBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
using Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class InvoiceFields : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Invoice Fields</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "invoiceFields");
            __builder.AddMarkupContent(3, "<label for=\"payerName\">Payer Name</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(4);
            __builder.AddAttribute(5, "id", "payerName");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
                                                                 Invoice.PayerName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Invoice.PayerName = __value, Invoice.PayerName))));
            __builder.AddAttribute(9, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Invoice.PayerName));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n\r\n    ");
            __builder.AddMarkupContent(11, "<label for=\"payerAdress\">Payer Adress</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
            __builder.AddAttribute(13, "id", "payerAdress");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
                                                                   Invoice.PayerAdress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Invoice.PayerAdress = __value, Invoice.PayerAdress))));
            __builder.AddAttribute(17, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Invoice.PayerAdress));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n\r\n    ");
            __builder.AddMarkupContent(19, "<label for=\"payerIBAN\">Payer IBAN</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
            __builder.AddAttribute(21, "id", "payerIBAN");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
                                                                 Invoice.PayerIBAN

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Invoice.PayerIBAN = __value, Invoice.PayerIBAN))));
            __builder.AddAttribute(25, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Invoice.PayerIBAN));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n\r\n    ");
            __builder.AddMarkupContent(27, "<label for=\"payerNumber\">Payer Number</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
            __builder.AddAttribute(29, "id", "payerNumber");
            __builder.AddAttribute(30, "class", "form-control");
            __builder.AddAttribute(31, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
                                                                   Invoice.PayerNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Invoice.PayerNumber = __value, Invoice.PayerNumber))));
            __builder.AddAttribute(33, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Invoice.PayerNumber));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n\r\n    ");
            __builder.AddMarkupContent(35, "<label for=\"recieverName\">Reciever Name</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
            __builder.AddAttribute(37, "id", "recieverName");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
                                                                    Invoice.RecieverName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Invoice.RecieverName = __value, Invoice.RecieverName))));
            __builder.AddAttribute(41, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Invoice.RecieverName));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n\r\n    ");
            __builder.AddMarkupContent(43, "<label for=\"recieverAdress\">Reciever Adress</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
            __builder.AddAttribute(45, "id", "recieverAdress");
            __builder.AddAttribute(46, "class", "form-control");
            __builder.AddAttribute(47, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
                                                                      Invoice.RecieverAdress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Invoice.RecieverAdress = __value, Invoice.RecieverAdress))));
            __builder.AddAttribute(49, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Invoice.RecieverAdress));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n\r\n    ");
            __builder.AddMarkupContent(51, "<label for=\"recieverNumber\">Reciever Number</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(52);
            __builder.AddAttribute(53, "id", "recieverNumber");
            __builder.AddAttribute(54, "class", "form-control");
            __builder.AddAttribute(55, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
                                                                      Invoice.RecieverNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Invoice.RecieverNumber = __value, Invoice.RecieverNumber))));
            __builder.AddAttribute(57, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Invoice.RecieverNumber));
            __builder.CloseComponent();
            __builder.AddMarkupContent(58, "\r\n\r\n    ");
            __builder.AddMarkupContent(59, "<label for=\"emergency\">Emergency</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(60);
            __builder.AddAttribute(61, "id", "emergency");
            __builder.AddAttribute(62, "class", "form-control");
            __builder.AddAttribute(63, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
                                                                     Invoice.Emergency

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Invoice.Emergency = __value, Invoice.Emergency))));
            __builder.AddAttribute(65, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => Invoice.Emergency));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n\r\n    ");
            __builder.AddMarkupContent(67, "<label for=\"amount\">Amount</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(68);
            __builder.AddAttribute(69, "id", "amount");
            __builder.AddAttribute(70, "class", "form-control");
            __builder.AddAttribute(71, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
                                                              Invoice.Amount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Invoice.Amount = __value, Invoice.Amount))));
            __builder.AddAttribute(73, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Invoice.Amount));
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\r\n\r\n    ");
            __builder.AddMarkupContent(75, "<label for=\"description\">Description</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(76);
            __builder.AddAttribute(77, "id", "description");
            __builder.AddAttribute(78, "class", "form-control");
            __builder.AddAttribute(79, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
                                                                   Invoice.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Invoice.Description = __value, Invoice.Description))));
            __builder.AddAttribute(81, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Invoice.Description));
            __builder.CloseComponent();
            __builder.AddMarkupContent(82, "\r\n\r\n    ");
            __builder.AddMarkupContent(83, "<label>Models</label>\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenDropDown<string>>(84);
            __builder.AddAttribute(85, "AllowClear", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "Class", "w-100");
            __builder.AddAttribute(87, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 38 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
                                   Models

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "Change", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 39 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
                                     args => OnChangeModels(args, "DropDown")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(89, "\r\n\r\n    ");
            __builder.AddMarkupContent(90, "<label>Currency</label>\r\n\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenDropDown<string>>(91);
            __builder.AddAttribute(92, "AllowClear", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "Class", "w-100");
            __builder.AddAttribute(94, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 44 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
                                   Currency

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "Change", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 45 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
                                     args => OnChangeCurrency(args, "DropDown")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\InvoiceFields.razor"
       
    [Parameter]
    public Invoice Invoice{ get; set; }

    IEnumerable<string> Models =  new string[] { "00", "01","02" };
    IEnumerable<string> Currency =  new string[] { "KN", "USD","EUR", "CZK" };

    void OnChangeModels(object value, string name)
    {
        Invoice.Model =(string) (value is IEnumerable<object> ? string.Join(", ", (IEnumerable<object>)value) : value);
    }

    void OnChangeCurrency(object value, string name)
    {
        Invoice.Currency =(string) (value is IEnumerable<object> ? string.Join(", ", (IEnumerable<object>)value) : value);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
