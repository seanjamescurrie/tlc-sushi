// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TLC.Web.ComponentsAdmin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using TLC.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using TLC.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using TLC.Web.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using TLC.Web.ComponentsProducts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using TLC.Web.ComponentsBasket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using TLC.Web.ComponentsOrders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using TLC.Web.ComponentsAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using TLC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using TLC.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using TLC.Data.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using TLC.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using TLC.Data.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using TLC.Blazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using TLC.Blazor.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using TLC.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\_Imports.razor"
using TLC.Core.Models;

#line default
#line hidden
#nullable disable
    public partial class ArchivedMenuItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsAdmin\ArchivedMenuItem.razor"
       
    // setting state/object as parameter to take on value of paramter passed to component from parent
    [Parameter]
    public Product EachProduct { get; set; }

    protected override void OnInitialized()
    {
        // retrieving basket and assigning basketItems to var for display
        // basket = basketService.GetBasket(BasketId);
        // basketItems = basket.BasketItems;

        // generating order from basketId
        // var order = orderService.CreateOrder();
        // order.BasketItems = basketItems;
        // order.TotalPrice = basket.TotalPrice;

    }

    private async Task AddProductSelect()
    {
        // here we are calling our js function from the IJSRuntimeExt...
        await js.MyFunction("custom message");
        // using JSRuntime to use the js confirm method to confirm deletion
        // we have created a finction to confirm in Helpers -> IJSRuntimeExt...
        var confirmed = await js.Confirm($"Are you sure you want to revive {EachProduct.Name} and add to menu?");
        if (confirmed)
        {
            var revived = productService.ReviveProduct(EachProduct.Id);
            StateHasChanged();
        }

    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBasketService basketService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrderService orderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService productService { get; set; }
    }
}
#pragma warning restore 1591
