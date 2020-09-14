using Entitas;
using UnityEngine;

namespace Systems.Gameplay.Enemy
{
    public class MoveEnemy : IExecuteSystem
    {
        private readonly GameContext game;
        private readonly IGroup<GameEntity> enemies;

        public MoveEnemy(GameContext game)
        {
            this.game = game;

            enemies = game.GetGroup(GameMatcher.AllOf(GameMatcher.Enemy, GameMatcher.Target));
        }

        public void Execute()
        {
            foreach (var enemy in enemies)
                Move(enemy, @in: enemy.target.value);
        }

        private void Move(GameEntity enemy, Vector2 @in)
        {
            enemy.rigidbody.value.MovePosition(@in * enemy.WalkSpeed * game.Time.DeltaTime);
            // UpdateDirection(enemy, @in.x);
        }

        // private static void UpdateDirection(GameEntity player, float direction)
        // {
        //     // ReSharper disable once CompareOfFloatsByEqualityOperator
        //     if (player.hasDirection && player.Direction == direction)
        //         return;
        //
        //     player.ReplaceDirection(Direction(direction));
        // }
        //
        // private static float Direction(float xDistance) => Mathf.Sign(xDistance);
    }
}