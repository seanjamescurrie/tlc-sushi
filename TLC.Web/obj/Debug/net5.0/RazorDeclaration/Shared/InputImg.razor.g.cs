// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TLC.Web.Shared
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
    public partial class InputImg : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\CodeBase\Project\TLC6 - Copy\TLC\TLC\TLC.Web\Shared\InputImg.razor"
        [Parameter] public string Label { get; set; } = "Image";
    // passing base64 representation of image to parent component
    [Parameter] public EventCallback<string> OnSelectedImage { get; set; }
    //
    [Parameter] public string ImageUrl { get; set; }
    private string imageBase64;

    async Task OnChange(InputFileChangeEventArgs e)
    {
        // allows user to select multiple files, in our case it is only one
        var imageFiles = e.GetMultipleFiles();

        // creating a byte array for file selected by user
        //open a stream to transfer data to buffer (base 64 representation)
        foreach (var imageFile in imageFiles)
        {
            var buffer = new byte[imageFile.Size];
            await imageFile.OpenReadStream().ReadAsync(buffer);

            imageBase64 = Convert.ToBase64String(buffer);

            // firing EventCallback
            await OnSelectedImage.InvokeAsync(imageBase64);
            // do not want both if statements showing images at one time
            ImageUrl = null;

            StateHasChanged();
        }
    }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591