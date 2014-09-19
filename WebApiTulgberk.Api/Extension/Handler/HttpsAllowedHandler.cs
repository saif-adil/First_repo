using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System.Net;

namespace WebApiTulgberk.Api.Extension.Handler
{
    public class HttpsAllowedHandler: DelegatingHandler
    {
        protected override  Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if(request.RequestUri.Scheme != Uri.UriSchemeHttps)
            {
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.Forbidden);
                response.ReasonPhrase = "only https ";

              return   Task<HttpResponseMessage>.FromResult(response);

            }

            return base.SendAsync(request, cancellationToken);

        }
    }
}