#pragma checksum "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsAdmin\ArchiveList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51932733f302ac846f08c86b1d8d99d20f659ea1"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class ArchiveList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container mt-6");
            __builder.AddMarkupContent(2, "<div class=\"row\"><div class=\"col-6\"><h6 class=\"card-title mt-2\"><b>CURRENT MENU</b></h6></div></div>\r\n\r\n\r\n    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-hover");
            __builder.AddMarkupContent(5, "<thead><tr><th class=\"col-1\">ID</th>\r\n                <th class=\"col-2\">Name</th>\r\n                <th class=\"col\">Description</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
            __builder.AddAttribute(7, "class", "thead");
#nullable restore
#line 30 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsAdmin\ArchiveList.razor"
             if (products != null && products.Count() > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsAdmin\ArchiveList.razor"
                 foreach (var product in products)
                {



#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TLC.Web.ComponentsAdmin.ArchivedMenuItem>(8);
            __builder.AddAttribute(9, "EachProduct", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TLC.Data.Models.Product>(
#nullable restore
#line 36 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsAdmin\ArchiveList.razor"
                                                   product

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 37 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsAdmin\ArchiveList.razor"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsAdmin\ArchiveList.razor"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<tr><td colspan=\"3\"><h6>You have no products!</h6></td></tr>");
#nullable restore
#line 47 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsAdmin\ArchiveList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsAdmin\ArchiveList.razor"
       
    private IList<Product> products = new List<Product>();

    protected override void OnInitialized()
    {
        // decoupling component from data thanks to DI, data comes from a service
        // good software architecture
        products = productService.GetArchived();
        // basket = basketService.CreateBasket();
    }

    private void NewProduct()
    {
        navManager.NavigateTo($"order-management/new-product");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService productService { get; set; }
    }
}
#pragma warning restore 1591
