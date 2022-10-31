using LightInject;
using ProxyTimeApplyer.Services.Interfaces;

namespace ProxyTimeApplyer.Services
{
    public class ServicesResolver
    {
        private readonly ServiceContainer _container;

        public ServicesResolver()
        {
            _container = new ServiceContainer();
        }

        public ServiceContainer ResolveServices()
        {
            _container.RegisterSingleton<IProxyTimezoneGetter, ProxyTimezoneGetter>();

            return _container;
        }
    }
}
