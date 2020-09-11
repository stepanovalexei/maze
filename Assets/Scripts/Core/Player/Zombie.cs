using Extensions;
using UnityEngine;

namespace Core.Player
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
    }
}