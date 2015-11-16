using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace Book.API.Negotiator
{
    public class MyNegotiator : DefaultContentNegotiator
    {
        // Понадобится только для разработки с поддержкой мобильных устройств
        public override ContentNegotiationResult Negotiate(Type type, HttpRequestMessage request,IEnumerable<MediaTypeFormatter> formatters)
        {
            if (request.Headers.UserAgent.ToString().ToLower().Contains("android"))
            {
                return new ContentNegotiationResult(new JsonMediaTypeFormatter(),
                    new MediaTypeHeaderValue("application/json")
                    );



            }
            return base.Negotiate(type, request, formatters);
        }
    }
}