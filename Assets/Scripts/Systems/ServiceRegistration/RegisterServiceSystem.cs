using System;
using Entitas;

namespace Systems.ServiceRegistration
{
    public class RegisterServiceSystem<TService> : IInitializeSystem
    {
        private readonly TService service;
        private readonly Action<TService> initServiceComponent;

        public RegisterServiceSystem(TService saveService, Action<TService> initServiceComponent)
        {
            service = saveService;
            this.initServiceComponent = initServiceComponent;
        }

        public void Initialize() => initServiceComponent(service);
    }
}