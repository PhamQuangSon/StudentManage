﻿using Microsoft.Practices.Unity;
using StudentManage.Services.Services;
using System.Web.Http;

namespace StudentManage.DistributedService.DI
{
    public class UnityRegister
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new UnityContainer();

            // If you are registering any components that implement IDisposable such as Entity Framework's DbContext,
            // you will want to make sure that these components get disposed of at the end of the request.
            // This is achieved by registering these components with a HierarchicalLifetimeManager.
            // Ex: container.RegisterType<IDbContext, DbContext>(new HierarchicalLifetimeManager());

            container.RegisterType<IUserService, UserService>();

            config.DependencyResolver = new UnityResolver(container);
        }
    }
}