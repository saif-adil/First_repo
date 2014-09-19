using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace WebApiTulgberk.Api.Customization.Handlers
{
    public class HttpsRequiredMessageHandler: DelegatingHandler
    {

        protected  override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if(request.RequestUri.Scheme    ==  Uri.UriSchemeHttps)
            {
                HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
                response.ReasonPhrase = "use https only";
               return Task.FromResult<HttpResponseMessage>(response);
            }

            return base.SendAsync(request,cancellationToken);
        }
    }
}