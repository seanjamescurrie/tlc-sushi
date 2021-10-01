/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static TLC.Web.Helpers.HttpResponseWrapper;

namespace TLC.Web.Helpers
{
    public interface IHttpService
    {
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        Task<HttpResponseWrapper<object>> Post<T>(string url, T data);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T data);
    }
}

// ------ This was taken from a tutorial*/