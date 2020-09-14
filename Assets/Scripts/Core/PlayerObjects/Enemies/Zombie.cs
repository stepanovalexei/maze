using Extensions;
using UnityEngine;

namespace Core.PlayerObjects.Enemies
{
    public class Zombie : EntityBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collided) => MarkDead(collided);
        private void OnCollisionEnter2D(Collision2D other) => MarkDead(other.collider);

        private void MarkDead(Collider2D collision)
        {
            Game
                .CollidingViewRegister
                .Take(collision.GetInstanceID())
                .With(x => x.Entity.isDead = true);
        }

        protected override void OnStart()
        {
            base.OnStart();
            Entity
                .AddWalkSpeed(50f)
                .AddTarget(Vector3.zero)
                .With(x => x.isZombie = true)
                .With(x => x.isEnemy = true);
        }
    }
}