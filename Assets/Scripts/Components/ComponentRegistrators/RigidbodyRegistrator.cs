﻿using UnityEngine;

namespace Components.ComponentRegistrators
{
    public class RigidbodyRegistrator : MonoBehaviour, IViewComponentRegistrator
    {
        public Rigidbody2D Rigidbody;
    
        public void Register(GameEntity entity) =>
            entity.AddRigidbody(Rigidbody);
    }
}