using Entitas;
using UnityEngine;

namespace Systems.Gameplay.Enemy
{
    public class FindDestinationToMove : IExecuteSystem
    {
        private readonly GameContext game;

        private readonly IGroup<GameEntity> enemies;
        private readonly IGroup<GameEntity> tilemaps;

        public FindDestinationToMove(GameContext game, InputContext input)
        {
            this.game = game;

            enemies = game.GetGroup(GameMatcher.AllOf(GameMatcher.Enemy, GameMatcher.Target));
            tilemaps = game.GetGroup(GameMatcher.Tilemap);
        }

        public void Execute()
        {
            foreach (var enemy in enemies)
            foreach (var tilemap in tilemaps)
            {
                // var map = tilemap.tilemap.value;
                // var direction = enemy.target.value - enemy.transform.value.position;
                // // tilemap.CellToWorld;
                // if (Mathf.Abs(horizontal.Horizontal) > 0 || Mathf.Abs(vertical.Vertical) > 0)
                // {
                //     Move(enemy, @in: direction);
                // }
                // else
                // {
                //     enemy.isMoving = false;
                //     enemy.isStoppedMoving = true;
                // }

            }
        }

        private static void Move(GameEntity enemy, Vector2 @in)
        {
            enemy.isMoving = true;
            enemy.isStoppedMoving = false;
            enemy.rigidbody.value.velocity = new Vector2(@in.x, @in.y) * enemy.WalkSpeed;

            UpdateDirection(enemy, @in.x);
        }

        private static void UpdateDirection(GameEntity player, float direction)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (player.hasDirection && player.Direction == direction)
                return;

            player.ReplaceDirection(Direction(direction));
        }

        private static float Direction(float xDistance) => Mathf.Sign(xDistance);
    }
}