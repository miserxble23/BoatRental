namespace NotificationApp.Infrastructure
{
    public class SimpleContainer
    {
        private Dictionary<Type, object> services;
        public SimpleContainer()
        {
            services = new Dictionary<Type, object>();
        }
        public void Register<T>(T service)
        {
            services[typeof(T)] = service;
        }
        public T Get<T>()
        {
            return (T)services[typeof(T)];
        }
    }
}
