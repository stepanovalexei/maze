// using Infrastructure;

using System;
using Services;
using UnityEngine;

namespace Core
{
    public class EntityBehaviour : MonoBehaviour
    {
        public UnityView View;

        public GameContext Game => Contexts.sharedInstance.game;
        public GameEntity Entity => View.Entity;
    
        private void Awake() => OnAwake();

        private void Start() => OnStart();

        private void OnDestroy()
        {
            if (View != null && View.Entity?.isEnabled == true)
                View.Entity.isDestructed = true;
        }

        private void OnEnable() => OnEnabled();

        private void OnDisable() => OnDisabled();

        protected virtual void OnAwake()
        { }

        protected virtual void OnStart()
        { }

        protected virtual void OnEnabled()
        { }

        protected virtual void OnDisabled()
        { }

        protected virtual void OnDestroying()
        { }
    }
}