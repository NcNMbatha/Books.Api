using Autofac;
using Books.Api.Utils;
using Books.Interface;
using Books.Interface.IRepository;
using Books.Interface.IService;
using Books.Repository;
using Books.Service;

namespace Books.Api.IoC
{
    public class AutofacModule: Module
    {
        private IConfigUtils _configUtils;

        public AutofacModule(IConfigUtils configUtils)
        {
            _configUtils = configUtils;
        }

        protected override void Load(ContainerBuilder builder)
        {
            RegisterRepositoryTypes(builder);
            RegisterServiceTypes(builder);
        }

        private void RegisterRepositoryTypes(ContainerBuilder builder)
        {
            builder.RegisterType<BookRepository>().As<IBookRepository>()
                   .InstancePerDependency()
                   .WithParameter("connectionString", _configUtils.GetBooksConnectionString);

        }

        private void RegisterServiceTypes(ContainerBuilder builder)
        {
            builder.RegisterType<ConfigUtils>()
                  .As<IConfigUtils>().InstancePerDependency();

            builder.RegisterType<BookService>()
                 .As<IBookService>().InstancePerDependency();
        }
    }
}
