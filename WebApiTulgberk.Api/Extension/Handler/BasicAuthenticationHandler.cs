using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Dependencies;
using WebApiDoodle.Web.MessageHandlers;
using WebApiTulgberk.Api.ServiceLayer;

namespace WebApiTulgberk.Api.Extension.Handler
{
    public class BasicAuthenticateHandler: BasicAuthenticationHandler
    {
        protected override System.Threading.Tasks.Task<System.Security.Principal.IPrincipal> AuthenticateUserAsync(HttpRequestMessage request, string username, string password, System.Threading.CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    internal static class HttpRequestMessageExtensions
    {
        internal static IMembershipService GetMembershipService(
        this HttpRequestMessage request)
        {
            return request.GetService<IMembershipService>();
        }
        private static TService GetService<TService>(
        this HttpRequestMessage request)
        {
            IDependencyScope dependencyScope =
            request.GetDependencyScope();
            TService service =
            (TService)dependencyScope
            .GetService(typeof(TService));
            return service;
        }
    }
}