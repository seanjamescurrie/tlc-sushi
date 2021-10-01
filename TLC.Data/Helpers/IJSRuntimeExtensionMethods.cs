/*using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TLC.Data.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            // passes message to the console with js function
            // InvokeVoidAsync are for js functions that do not return values
            await js.InvokeVoidAsync("console.log", "example message");
            // encapsulated functionality in c# method
            return await js.InvokeAsync<bool>("confirm", message);
        }

        // we do not need ValueTask<> brackets as the function doesn't return any values
        public static async ValueTask MyFunction(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("my_function", message);
        }
    }
}*/
