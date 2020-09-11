using Entitas;

namespace View
{
    public interface IView
    {
        IView Initialize(GameContext @in, IEntity with);
        GameEntity Entity { get; }
        void Destroy();
    }
}