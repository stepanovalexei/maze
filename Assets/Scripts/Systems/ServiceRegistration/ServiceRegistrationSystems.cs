using Services;
using View;

namespace Systems.ServiceRegistration
{
    public class ServiceRegistrationSystems : Feature
    {
        public ServiceRegistrationSystems(GameContext game,InputContext input, Services.Services services)
            : base(nameof(ServiceRegistrationSystems))
        {
            Add(new RegisterServiceSystem<ITimeService>(services.Time, game.ReplaceTime));
            Add(new RegisterServiceSystem<IInputService>(services.InputService, input.ReplaceInput));
            Add(new RegisterServiceSystem<IRegisterService<IView>>(services.CollidingViewRegister, game.ReplaceCollidingViewRegister));
        }
    }
}