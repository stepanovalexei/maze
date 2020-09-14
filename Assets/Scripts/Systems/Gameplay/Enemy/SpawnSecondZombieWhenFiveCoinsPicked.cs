using System.Collections.Generic;
using Entitas;
using Entity;
using Extensions;

namespace Systems.Gameplay.Enemy
{
    public class SpawnSecondZombieWhenFiveCoinsPicked : ReactiveSystem<GameEntity>
    {
        private const int CoinsNeeded = 5;

        private readonly GameContext game;
        private readonly IGroup<GameEntity> scores;

        public SpawnSecondZombieWhenFiveCoinsPicked(GameContext game) : base(game) => this.game = game;

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
            context.CreateCollector(GameMatcher.Score);

        protected override bool Filter(GameEntity entity) =>
            entity.Score == CoinsNeeded;

        protected override void Execute(List<GameEntity> entities) =>
            CreateEntity
                .Empty()
                .With(x => x.SpawnZombie = true);
    }
}