using AgriculturePresentationApp.Business.Mapping;
using AgriculturePresentationApp.Business.Services.Concretes;
using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.DataAccess.Contexts;
using AgriculturePresentationApp.DataAccess.Repositories.Concretes;
using AgriculturePresentationApp.DataAccess.Repositories.Interfaces;
using AgriculturePresentationApp.DataAccess.UnitOfWorks;
using Autofac;
using FluentValidation;
using System.Reflection;
using Module = Autofac.Module;

namespace AgriculturePresentationApp.Web.Modules
{
    public class DIModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(GenericService<,,,,>)).As(typeof(IGenericService<,,,,>)).InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitofWork>().InstancePerLifetimeScope();

            builder.RegisterType<AssistanceService>().As<IAssistanceService>().InstancePerLifetimeScope();

            var assembly = Assembly.GetExecutingAssembly();

            var repoAssembly = Assembly.GetAssembly(typeof(AgriculturePresentationAppDbContext));

            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(assembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(assembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();
            
            //builder.RegisterType<ProductServiceWithCaching>().As<IProductService>();

            // InstancePerLifetimeScope => Scope

            // InstancePerDependency => transient


        }


    }
}
