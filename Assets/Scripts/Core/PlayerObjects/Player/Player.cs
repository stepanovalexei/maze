using Extensions;

namespace Core.PlayerObjects.Player
{
    public class Player : EntityBehaviour
    {
        protected override void OnStart()
        {
            Entity.With(x => x.isPlayer = true)
                .AddPosition(transform.position)
                .AddTransform(transform);
        }
    }
}