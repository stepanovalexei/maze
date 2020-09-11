using View;

namespace Services
{
    public class Services
    {
        public ITimeService Time;
        public IInputService InputService;
        public IRegisterService<IView> CollidingViewRegister;
        public GameIdentifierService Identifiers;
    }
}