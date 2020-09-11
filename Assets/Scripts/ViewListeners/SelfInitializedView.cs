using Core;
using Entity;
using View.Extensions;

namespace ViewListeners
{
    public class SelfInitializedView : EntityBehaviour
    {
        private GameEntity entity;

        protected override void OnAwake()
        {
            base.OnAwake();
            entity = CreateEntity.Empty();

            View.Initialize(Contexts.sharedInstance.game, entity);
            gameObject.RegisterListeners(entity);
        }
    }
}