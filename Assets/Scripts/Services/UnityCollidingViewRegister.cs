using System.Collections.Generic;
using View;

namespace Services
{
    public class UnityCollidingViewRegister : IRegisterService<IView>
    {
        private readonly Dictionary<int, IView> controllerByInstanceId = new Dictionary<int, IView>();

        public IView Register(int instanceId, IView viewController)
        {
            controllerByInstanceId[instanceId] = viewController;
            return viewController;
        }

        public void Unregister(int instanceId, IView @object)
        {
            if (controllerByInstanceId.ContainsKey(instanceId))
                controllerByInstanceId.Remove(instanceId);
        }

        public IView Take(int key) => 
            controllerByInstanceId.TryGetValue(key, out var behaviour) 
                ? behaviour 
                : null;
    }
}