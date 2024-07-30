namespace DesignPatterns.Decorator
{
    public class Decorator
    {
        // Interface dos serviços
        public interface ISomeService
        {
            void SomeOperation();
        }

        // Um tipo de Serviço
        public class ServiceOne : ISomeService
        {
            public void SomeOperation()
            {
                Console.WriteLine("Some action");
            }
        }

        // Um tipo de Serviço
        public class ServiceTwo : ISomeService
        {
            public void SomeOperation()
            {
                Console.WriteLine("Some action");
            }
        }

        // Decorador abstrato - só pode ser herdado
        // Permiti compor relações com os diferentes serviços que implementam ISomeService
        public abstract class ServiceDecorator : ISomeService
        {
            private readonly ISomeService _service;

            public ServiceDecorator(ISomeService service)
            {
                _service = service;
            }

            // Método que pode ser sobreposto
            public virtual void SomeOperation()
            {
                _service.SomeOperation();
            }
        }


        // Um decorador para cache
        // "decora" um ISomeService com a funcionalidade de cache
        public class ServiceCached : ServiceDecorator
        {
            public ServiceCached(ISomeService service) : base(service) { }

            // Método base sobreposto
            public override void SomeOperation()
            {
                Console.WriteLine("Cached");
                base.SomeOperation();
            }
        }

        // Um decorador para logging
        // "decora" um ISomeService com a funcionalidade de logging
        public class ServiceLogging : ServiceDecorator
        {
            public ServiceLogging(ISomeService service) : base(service) { }

            public override void SomeOperation()
            {
                Console.WriteLine("Logging");
                base.SomeOperation();
            }
        }

        // Exemplo de chamadas no código cliente
        public class ClientCode
        {
            public void Consumer()
            {
                // Criando serviços sem novas funcionalidades
                var service1 = new ServiceOne();
                var service2 = new ServiceTwo();

                service1.SomeOperation();
                service2.SomeOperation();

                // Criando serviços com cache
                var service1Cache = new ServiceCached(new ServiceOne());
                var service2Cache = new ServiceCached(new ServiceTwo());

                // 1. ServiceCached chama ServiceDecorator
                // 2. ServiceDecorator chama uma implementação de ISomeService
                // 3. Uma implementação de ISomeService chama SomeOperation()
                service1Cache.SomeOperation();
                service2Cache.SomeOperation();

                // Criando serviços com cache e logging
                var service1CacheAndLog = new ServiceCached(new ServiceLogging(new ServiceOne()));
                var service2CacheAndLog = new ServiceCached(new ServiceLogging(new ServiceTwo()));

                service1CacheAndLog.SomeOperation();
                service2CacheAndLog.SomeOperation();
            }
        }
    }
}
