// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 12 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\EditInvoice.razor"
using Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\EditInvoice.razor"
using InvoiceBlazorServer.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditInvoice/{InvoiceId}")]
    public partial class EditInvoice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Ilario\source\repos\CSherp_Vjezba5\InvoiceBlazorServer\Pages\EditInvoice.razor"
       
    [Parameter]
    public string InvoiceId { get; set; }

    public Invoice Invoice { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Invoice = await _invoiceService.GetInvoiceAsync(int.Parse(InvoiceId));
    }
    private async Task UpdateInvoiceAsync()
    {
        await _invoiceService.UpdateInvoiceAsync(Invoice);
        Close();
    }
    private void Close()
    {
        _navigationManager.NavigateTo("/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private InvoiceService _invoiceService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591