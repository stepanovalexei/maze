using System;
using Entitas;
using Extensions;
using Services;
using UnityEngine;
using View;

namespace ViewListeners
{
    public class DestructedListener : MonoBehaviour, IEventListener, IDestructedListener
    {
        private GameEntity entity;

        public void RegisterListeners(IEntity entity)
        {
            this.entity = (GameEntity) entity;
            this.entity.AddDestructedListener(this);
        }

        public void UnregisterListeners(IEntity with) =>
            entity.RemoveDestructedListener();

        public void OnDestructed(GameEntity entity) =>
            this.Do(Cleanup(entity), when: entity.isDestructed);

        private Action<DestructedListener> Cleanup(GameEntity entity) =>
            listener =>
            {
                var view = gameObject.GetComponent<IView>();
                view.Destroy();
            };
    }
}