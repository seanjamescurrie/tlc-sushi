#pragma checksum "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dcfe1e3e24b471da97d01c9a63c8f5bd4ac13d1"
// <auto-generated/>
#pragma warning disable 1591
namespace TLC.Web.ComponentsOrders
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/confirm-order/{BasketId:int}")]
    public partial class ConfirmOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
 if (basket != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card border-dark mt-4 rounded-sm confirm-order-form mx-auto");
            __builder.AddAttribute(2, "b-11fp70ztpq");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-verticle");
            __builder.AddAttribute(5, "b-11fp70ztpq");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-body d-flex flex-column");
            __builder.AddAttribute(8, "b-11fp70ztpq");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "container");
            __builder.AddAttribute(11, "b-11fp70ztpq");
            __builder.AddMarkupContent(12, "<div class=\"order-title\" b-11fp70ztpq><h6 b-11fp70ztpq><b b-11fp70ztpq>CONFIRM ORDER</b></h6></div>\r\n\r\n\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
                                     order

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "class", "form-line");
            __builder.AddAttribute(16, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 19 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
                                                                             OnDataAnnotationsValidated

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(18);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n                        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "border-control");
                __builder2.AddAttribute(22, "b-11fp70ztpq");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "row");
                __builder2.AddAttribute(25, "b-11fp70ztpq");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-6 form-group");
                __builder2.AddAttribute(28, "b-11fp70ztpq");
                __builder2.AddMarkupContent(29, "<label for=\"name\" b-11fp70ztpq><b b-11fp70ztpq>Name</b></label>\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "id", "name");
                __builder2.AddAttribute(32, "class", "form-control");
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
                                                                      order.CustomerName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => order.CustomerName = __value, order.CustomerName))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => order.CustomerName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n                                    ");
                __Blazor.TLC.Web.ComponentsOrders.ConfirmOrder.TypeInference.CreateValidationMessage_0(__builder2, 37, 38, 
#nullable restore
#line 26 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
                                                             () => order.CustomerName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n                                ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "col-6 form-group");
                __builder2.AddAttribute(42, "b-11fp70ztpq");
                __builder2.AddMarkupContent(43, "<label for=\"name\" b-11fp70ztpq><b b-11fp70ztpq>Email</b></label>\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "id", "address");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
                                                                         order.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => order.EmailAddress = __value, order.EmailAddress))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => order.EmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n                                    ");
                __Blazor.TLC.Web.ComponentsOrders.ConfirmOrder.TypeInference.CreateValidationMessage_1(__builder2, 51, 52, 
#nullable restore
#line 32 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
                                                             () => order.EmailAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n\r\n                            ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "row");
                __builder2.AddAttribute(56, "b-11fp70ztpq");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "col form-group");
                __builder2.AddAttribute(59, "b-11fp70ztpq");
                __builder2.AddMarkupContent(60, "<label for=\"name\" b-11fp70ztpq><b b-11fp70ztpq>Address</b></label>\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "id", "address");
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
                                                                         order.CustomerAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => order.CustomerAddress = __value, order.CustomerAddress))));
                __builder2.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => order.CustomerAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n                                    ");
                __Blazor.TLC.Web.ComponentsOrders.ConfirmOrder.TypeInference.CreateValidationMessage_2(__builder2, 68, 69, 
#nullable restore
#line 40 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
                                                             () => order.CustomerAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n\r\n                            ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "row");
                __builder2.AddAttribute(73, "b-11fp70ztpq");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "col-6 form-group");
                __builder2.AddAttribute(76, "b-11fp70ztpq");
                __builder2.AddMarkupContent(77, "<label for=\"deliveryDate\" b-11fp70ztpq><b b-11fp70ztpq>Pickup/Delivery Date *</b></label>\r\n                                    ");
                __Blazor.TLC.Web.ComponentsOrders.ConfirmOrder.TypeInference.CreateInputDate_3(__builder2, 78, 79, "deliveryDate", 80, "form-control", 81, 
#nullable restore
#line 47 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
                                                                              order.DeliveryDate

#line default
#line hidden
#nullable disable
                , 82, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => order.DeliveryDate = __value, order.DeliveryDate)), 83, () => order.DeliveryDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n\r\n                                ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "col-6 form-group");
                __builder2.AddAttribute(87, "b-11fp70ztpq");
                __builder2.AddMarkupContent(88, "<label for=\"name\" b-11fp70ztpq><b b-11fp70ztpq>Delivery</b></label>\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(89);
                __builder2.AddAttribute(90, "id", "delivery");
                __builder2.AddAttribute(91, "class", "form-control");
                __builder2.AddAttribute(92, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 52 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
                                                                              order.Delivery

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => order.Delivery = __value, order.Delivery))));
                __builder2.AddAttribute(94, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => order.Delivery));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n\r\n                            ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "row");
                __builder2.AddAttribute(98, "b-11fp70ztpq");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "col-6 form-group");
                __builder2.AddAttribute(101, "b-11fp70ztpq");
                __builder2.AddMarkupContent(102, "<label for=\"summary\" b-11fp70ztpq><b b-11fp70ztpq>Order Summary</b></label>\r\n                                    ");
                __builder2.OpenElement(103, "ol");
                __builder2.AddAttribute(104, "b-11fp70ztpq");
#nullable restore
#line 60 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
                                         foreach (var item in order.BasketItems)
                                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(105, "li");
                __builder2.AddAttribute(106, "b-11fp70ztpq");
                __builder2.AddContent(107, 
#nullable restore
#line 62 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
                                                 item.Product.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(108, " ");
                __builder2.OpenElement(109, "b");
                __builder2.AddAttribute(110, "b-11fp70ztpq");
                __builder2.AddContent(111, "(");
                __builder2.AddContent(112, 
#nullable restore
#line 62 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
                                                                        item.Quantity

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(113, ")");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 63 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
                                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n\r\n                                ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "col-6 form-group");
                __builder2.AddAttribute(117, "b-11fp70ztpq");
                __builder2.AddMarkupContent(118, "<label for=\"totalPrice\" b-11fp70ztpq><b b-11fp70ztpq>Total Price</b></label>\r\n                                    ");
                __builder2.OpenElement(119, "h4");
                __builder2.AddAttribute(120, "b-11fp70ztpq");
                __builder2.OpenElement(121, "b");
                __builder2.AddAttribute(122, "b-11fp70ztpq");
                __builder2.AddMarkupContent(123, "??");
                __builder2.AddContent(124, 
#nullable restore
#line 69 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
                                             basket.TotalPrice.ToString("#.##")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n\r\n\r\n                        ");
                __builder2.OpenElement(126, "div");
                __builder2.AddAttribute(127, "class", "border-control");
                __builder2.AddAttribute(128, "b-11fp70ztpq");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "class", "row");
                __builder2.AddAttribute(131, "b-11fp70ztpq");
                __builder2.AddMarkupContent(132, "<div class=\"col-6 form-group\" b-11fp70ztpq><button type=\"submit\" class=\"basket btn btn-outline-dark btn-sm rounded-pill mt-3 btn-block\" b-11fp70ztpq><b b-11fp70ztpq>CONFIRM ORDER</b></button></div>\r\n                                ");
                __builder2.OpenElement(133, "div");
                __builder2.AddAttribute(134, "class", "col-6 form-group");
                __builder2.AddAttribute(135, "b-11fp70ztpq");
                __builder2.OpenElement(136, "button");
                __builder2.AddAttribute(137, "type", "button");
                __builder2.AddAttribute(138, "class", "basket btn btn-warning btn-sm rounded-pill mt-3 btn-block");
                __builder2.AddAttribute(139, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
                                                        () => OnCancel()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(140, "b-11fp70ztpq");
                __builder2.AddMarkupContent(141, "<b b-11fp70ztpq>CANCEL ORDER</b>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(142, "\r\n\r\n                        ");
                __builder2.AddMarkupContent(143, "<div class=\"row mt-2\" b-11fp70ztpq><div class=\"col\" b-11fp70ztpq><p b-11fp70ztpq><i b-11fp70ztpq>* Pickup/Deliveries are <b b-11fp70ztpq>Friday or Saturday, 3 PM - 6 PM</b></i></p></div></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 104 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\ComponentsOrders\ConfirmOrder.razor"
       
    // [Parameter] public Order order { get; set; }
    [Parameter] public int BasketId { get; set; }
    // [Parameter] public Order Order { get; set; }

    // [Parameter] public EventCallback<Order> Confirmed { get; set; }

    public List<BasketItem> basketItems;
    public Order order = new Order();
    public Basket basket = new Basket();

    protected override void OnInitialized()
    {
        // retrieving basket and assigning basketItems to var for display
        basket = basketService.GetBasket(BasketId);
        basketItems = basket.BasketItems;

        // assigning order info from BasketId
        // order = orderService.CreateOrder();
        order.BasketItems = basketItems;
        order.TotalPrice = basket.TotalPrice;
        order.CustBasketId = basket.Id;

    }

    protected void OnDataAnnotationsValidated()
    {
        order = orderService.EditOrder(order);

        foreach(var item in order.BasketItems)
        {
            var productSold = productService.GetProduct(item.ProductId);
            productSold.Sold += item.Quantity;
        }
        // Confirmed.InvokeAsync(order);
        navManager.NavigateTo($"/");
    }

    private void OnCancel()
    {
        basketService.Empty(basket.Id);
        navManager.NavigateTo($"/", true);
        orderService.DeleteOrder(order.Id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService productService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBasketService basketService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrderService orderService { get; set; }
    }
}
namespace __Blazor.TLC.Web.ComponentsOrders.ConfirmOrder
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
