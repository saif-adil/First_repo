using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using WebApiTulgberk.Api.Extension.Handler;
using System.Web.Http.ModelBinding;
using System.Net.Http.Formatting;
using System.Web.Http.Validation;
using System.Web.Http.Validation.Providers;

namespace WebApiTulgberk.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

           // config.Formatters.FirstOrDefault(p=>p.GetType() == );
            config.MessageHandlers.Add(new HttpsAllowedHandler());
            // Web API routes
            config.MapHttpAttributeRoutes();

            //Formatters
            var jqueryFormatter = config.Formatters.FirstOrDefault(
            x => x.GetType() ==
            typeof(JQueryMvcFormUrlEncodedFormatter));
            config.Formatters.Remove(
            config.Formatters.FormUrlEncodedFormatter);
            config.Formatters.Remove(jqueryFormatter);
            //foreach (var formatter in config.Formatters)
            //{
            //    formatter.RequiredMemberSelector =
            //    new SuppressedRequiredMemberSelector();
            //}
            //Default Services
            config.Services.Replace(
            typeof(IContentNegotiator),
            new DefaultContentNegotiator(
            excludeMatchOnTypeOnly: true));
            config.Services.RemoveAll(
            typeof(ModelValidatorProvider),
            validator => !(validator
            is DataAnnotationsModelValidatorProvider));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
