using UnityEngine;

namespace Components.ComponentRegistrators
{
    public class RigidbodyRegistrator : MonoBehaviour, IComponentRegistrator
    {
        public Rigidbody2D Rigidbody;
    
        public void Register(GameEntity entity) =>
            entity.AddRigidbody(Rigidbody);
    }
}