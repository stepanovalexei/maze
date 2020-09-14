using Core.PlayerObjects.Player;
using Entitas;
using Services;
using UnityEngine;

namespace ViewListeners
{
    public class MovingListener : MonoBehaviour, IMovingListener, IStoppedMovingListener, IEventListener
    {
        public PlayerAnimator Animator;
        private GameEntity entity;

        public void RegisterListeners(IEntity entity)
        {
            this.entity = (GameEntity) entity;
            this.entity.AddMovingListener(this);
            this.entity.AddStoppedMovingListener(this);
        }

        public void UnregisterListeners(IEntity with)
        {
            entity.RemoveMovingListener();
            entity.RemoveStoppedMovingListener();
        }

        public void OnMoving(GameEntity entity) =>
            Animator.PlayMove();

        public void OnStoppedMoving(GameEntity entity)
        {
            Animator.PlayIdle();
            entity.isStoppedMoving = false;
        }
    }
}