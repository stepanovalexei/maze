using Extensions;
using UnityEngine;

namespace Core.PlayerObjects.Enemies
{
    public class Mummy : EntityBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collided) => MarkDead(collided);
        private void OnCollisionEnter2D(Collision2D other) => MarkDead(other.collider);

        private void MarkDead(Collider2D collision)
        {
            Game
                .CollidingViewRegister
                .Take(collision.GetInstanceID())
                .With(x => x.Entity.isDead = true)
                .With(x => x.Entity.isHitByMummy = true);
        }

        protected override void OnStart()
        {
            base.OnStart();
            Entity
                .AddWalkSpeed(1f)
                .With(x => x.isMummy = true)
                .With(x => x.isEnemy = true);
        }
    }
}