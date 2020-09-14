using Components.ComponentRegistrators;
using Entitas;
using Entitas.VisualDebugging.Unity;
using UnityEngine;
using View;
using View.Extensions;

namespace Core
{
    public class UnityView : MonoBehaviour, IView
    {
        public GameContext Game { get; private set; }
        public GameEntity Entity { get; private set; }

        public IView Initialize(GameContext game, IEntity entity)
        {
            Game = game;
            Entity = (GameEntity) entity;

            RegisterViewComponents();

            return this;
        }

        public void Destroy()
        {
            UnregisterCollisions();
            gameObject.UnregisterListeners(Entity);
            gameObject.DestroyGameObject();
        }

        private void Start()
        {
            RegisterCollisions();
        }

        private void RegisterViewComponents()
        {
            foreach (var registrator in GetComponents<IComponentRegistrator>())
                registrator.Register(Entity);
        }

        private void RegisterCollisions()
        {
            foreach (var collider in GetComponentsInChildren<Collider2D>(includeInactive: true))
                Game.CollidingViewRegister.Register(collider.GetInstanceID(), this);
        }

        private void UnregisterCollisions()
        {
            foreach (var collider in GetComponentsInChildren<Collider2D>())
                Game.CollidingViewRegister.Unregister(collider.GetInstanceID(), this);
        }
    }
}