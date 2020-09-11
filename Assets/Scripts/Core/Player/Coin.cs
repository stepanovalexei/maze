using Extensions;
using UnityEngine;

namespace Core.Player
{
    public class Coin : EntityBehaviour
    {
        protected override void OnStart()
        {
            base.OnStart();
            Entity.With(x => x.isCoin = true);
        }

        private void OnTriggerEnter2D(Collider2D collided) => MarkPicked(collided);
        private void OnCollisionEnter2D(Collision2D other) => MarkPicked(other.collider);

        private void MarkPicked(Collider2D collision)
        {
            Entity.isPicked = true;
        }
    }
}