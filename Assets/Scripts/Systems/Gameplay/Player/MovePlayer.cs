using Entitas;
using UnityEngine;

namespace Systems.Gameplay.Player
{
    public class MovePlayer : IExecuteSystem
    {
        private const float Speed = 15f;
        private readonly GameContext game;

        private readonly IGroup<GameEntity> heroes;
        private readonly IGroup<InputEntity> verticals;
        private readonly IGroup<InputEntity> horizontals;

        public MovePlayer(GameContext game, InputContext input)
        {
            this.game = game;

            heroes = game.GetGroup(GameMatcher.AllOf(GameMatcher.Player));
            verticals = input.GetGroup(InputMatcher.AllOf(InputMatcher.Vertical));
            horizontals = input.GetGroup(InputMatcher.AllOf(InputMatcher.Horizontal));
        }

        public void Execute()
        {
            foreach (var vertical in verticals)
            foreach (var horizontal in horizontals)
            foreach (var hero in heroes)
            {
                var direction = new Vector2(horizontal.Horizontal, vertical.Vertical);
                if (Mathf.Abs(horizontal.Horizontal) > 0 || Mathf.Abs(vertical.Vertical) > 0)
                    Move(hero, @in: direction);
                else
                    hero.isMoving = false;
            }
        }

        private static void Move(GameEntity player, Vector2 @in)
        {
            player.isMoving = true;
            player.rigidbody.value.velocity = new Vector2(@in.x, @in.y) * Speed;
        }
    }
}