#pragma checksum "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\Pages\ManageBusiness.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94a0014bc0edc15c12bce8dfe8e3235da3b04df1"
// <auto-generated/>
#pragma warning disable 1591
namespace TLC.Web.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/order-management")]
    public partial class ManageBusiness : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "nav-container");
            __builder.AddAttribute(2, "b-8jvhgpzpib");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row d-flex mt-6 mb-2 my-auto");
            __builder.AddAttribute(5, "b-8jvhgpzpib");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-12 text-center");
            __builder.AddAttribute(8, "b-8jvhgpzpib");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "type", "button");
            __builder.AddAttribute(11, "class", "menu-nav btn btn-outline-dark btn rounded-pill");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\Pages\ManageBusiness.razor"
                                () => ShowOrders()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-8jvhgpzpib");
            __builder.AddMarkupContent(14, "<b b-8jvhgpzpib>ORDERS</b>");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n            ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "class", "menu-nav btn btn-outline-dark btn rounded-pill");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\Pages\ManageBusiness.razor"
                                () => ShowMenu()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "b-8jvhgpzpib");
            __builder.AddMarkupContent(21, "<b b-8jvhgpzpib>MENU ITEMS</b>");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n            ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "type", "button");
            __builder.AddAttribute(25, "class", "menu-nav btn btn-outline-dark btn rounded-pill");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\Pages\ManageBusiness.razor"
                                () => ShowArchive()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "b-8jvhgpzpib");
            __builder.AddMarkupContent(28, "<b b-8jvhgpzpib>ARCHIVE</b>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "OrderList");
            __builder.AddAttribute(32, "hidden", 
#nullable restore
#line 28 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\Pages\ManageBusiness.razor"
                                showOrders

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "b-8jvhgpzpib");
            __builder.OpenComponent<TLC.Web.ComponentsAdmin.OrderList>(34);
            __builder.AddAttribute(35, "Orders", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IList<TLC.Data.Models.Order>>(
#nullable restore
#line 29 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\Pages\ManageBusiness.razor"
                       orders

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "MenuList");
            __builder.AddAttribute(39, "hidden", 
#nullable restore
#line 32 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\Pages\ManageBusiness.razor"
                               showMenu

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(40, "b-8jvhgpzpib");
            __builder.OpenComponent<TLC.Web.ComponentsAdmin.MenuList>(41);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "ArchiveList");
            __builder.AddAttribute(45, "hidden", 
#nullable restore
#line 36 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\Pages\ManageBusiness.razor"
                                  showArchive

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(46, "b-8jvhgpzpib");
            __builder.OpenComponent<TLC.Web.ComponentsAdmin.ArchiveList>(47);
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\Pages\ManageBusiness.razor"
       

    private IList<Order> orders = new List<Order>();
    private bool showOrders;
    private bool showMenu;
    private bool showArchive;

    protected override void OnInitialized()
    {
        // decoupling component from data thanks to DI, data comes from a service
        // good software architecture
        orders = orderService.GetOrders();
        showOrders = false;
        showMenu = true;
        showArchive = true;
    }

    private void ShowMenu()
    {
        showMenu = false;
        showOrders = true;
        showArchive = true;
    }

    private void ShowOrders()
    {
        showMenu = true;
        showOrders = false;
        showArchive = true;
    }

    private void ShowArchive()
    {
        showMenu = true;
        showOrders = true;
        showArchive = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrderService orderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBasketService basketService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService productService { get; set; }
    }
}
#pragma warning restore 1591
