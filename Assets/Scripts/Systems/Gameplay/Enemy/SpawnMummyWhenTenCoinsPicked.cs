using System.Collections.Generic;
using Entitas;
using Entity;
using Extensions;

namespace Systems.Gameplay.Enemy
{
    public class SpawnMummyWhenTenCoinsPicked : ReactiveSystem<GameEntity>
    {
        private const int CoinsNeeded = 10;

        private readonly GameContext game;
        private readonly IGroup<GameEntity> scores;

        public SpawnMummyWhenTenCoinsPicked(GameContext game) : base(game) => this.game = game;

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
            context.CreateCollector(GameMatcher.Score);

        protected override bool Filter(GameEntity entity) =>
            entity.Score == CoinsNeeded;

        protected override void Execute(List<GameEntity> entities) =>
            CreateEntity
                .Empty()
                .With(x => x.SpawnMummy = true);
    }
}