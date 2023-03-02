using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using MyDataBase;
using Repository;
using Repository.Interfaces;
using Servise.Interfaces;

namespace Dash.cs
{
    public static class Bootstrap
    {
        public static WindsorContainer BuildContainer()
        {
            WindsorContainer container = new WindsorContainer();
            container.Register(Component.For<DbContext>().ImplementedBy<MyDataBasEntityContext>());
            container.Register(Component.For<IUnitOfWork>().ImplementedBy<UnitOfWork>());
            container.Register(Classes.FromAssemblyNamed("Repository").BasedOn(typeof(IRepository<>)).WithService.Base().WithServiceDefaultInterfaces());
            container.Register(Classes.FromAssemblyNamed("Servise").BasedOn(typeof(IServise)).WithService.Base().WithServiceDefaultInterfaces());
            return container;
        }
    }
}
