/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TLC.Web.Helpers
{
    public class HttpResponseWrapper
    {

        // <T> makes class generic
        public class HttpResponseWrapper<T>
        {

            public HttpResponseWrapper(T response, bool success, HttpResponseMessage httpResponseMessage)
            {
                Success = success;
                Response = response;
                HttpResponseMessage = httpResponseMessage;
            }
            public bool Success { get; set; }

            // deserialized reponse
            public T Response { get; set; }
            public HttpResponseMessage HttpResponseMessage { get; set; }

            // important as sometimes in body of response of Http request we get a message of errors that occur
            public async Task<string>
                GetBody()
            {
                return await HttpResponseMessage.Content.ReadAsStringAsync();
            }
        }
    }
}

    // ------ This was taken from a tutorial*/