using Entitas;
using Extensions;
using Services;
using UnityEngine;

namespace ViewListeners
{
    public class DirectionListener : MonoBehaviour, IEventListener, IDirectionListener
    {
        private GameEntity entity;

        public void RegisterListeners(IEntity entity)
        {
            this.entity = (GameEntity)entity;
            this.entity.AddDirectionListener(this);

            UpdateCurrentDirection();
        }

        public void UnregisterListeners(IEntity with) => 
            entity.RemoveDirectionListener();

        public void OnDirection(GameEntity entity, float direction)
        {
            float currentXScaleValue = Mathf.Abs(transform.localScale.x);
            transform.LocalScaleX(currentXScaleValue * direction);
        }

        private void UpdateCurrentDirection()
        {
            if (entity.hasDirection)
                OnDirection(entity, entity.Direction);
        }
    }
}