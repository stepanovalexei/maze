using Entitas;

namespace Services
{
    public interface IEventListener
    {
        void RegisterListeners(IEntity entity);
        void UnregisterListeners(IEntity with);
    }
}