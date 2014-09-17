using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using WebApiTulgberk.Domain;
using System.Data.Entity;
using WebApiTulgberk.Api.ServiceLayer;
using WebApiTulgberk.Domain.Entities;

namespace WebApiTulgberk.Api.App_Start
{
    public class AutofacWebApi
    {
    }
    public class AutofacWebAPI
    {
        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config,
            RegisterServices(new ContainerBuilder()));
        }
        public static void Initialize(
        HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver =
            new AutofacWebApiDependencyResolver(container);
        }
        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            // registration goes here

            builder.RegisterType<EntitiesContext>().As<DbContext>();

            builder.RegisterGeneric(typeof(EntityRepository<>)).As(typeof( IEntityRepository<>));

            builder.RegisterType<CryptoService>()
.As<ICryptoService>();

            builder.RegisterType<MembershipService>()
            .As<IMembershipService>();

            builder.RegisterType<ShipmentService>()
            .As<IShipmentService>();

            builder.RegisterType<EntitiesContext>().As<DbContext>();

            return builder.Build();
        }
    }
}