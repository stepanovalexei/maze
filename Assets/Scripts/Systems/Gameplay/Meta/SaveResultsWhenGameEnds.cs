using System.Collections.Generic;
using Entitas;
using MainMenu.Results;

namespace Systems.Gameplay.Statistics
{
    public class SaveResultsWhenGameEnds : ReactiveSystem<GameEntity>
    {
        private readonly MetaContext meta;
        private readonly GameContext game;
        private float timePlayed;

        public SaveResultsWhenGameEnds(MetaContext meta, GameContext game) : base(game)
        {
            this.meta = meta;
            this.game = game;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
            context.CreateCollector(
                GameMatcher.Quit.Added(),
                GameMatcher.OnApplicationQuit.Added(),
                GameMatcher.Dead.Added());

        protected override bool Filter(GameEntity entity) =>
            entity.isQuit ||
            entity.isOnApplicationQuit ||
            entity.isDead;

        protected override void Execute(List<GameEntity> entities)
        {
            var reason =
                game.isQuit || game.isOnApplicationQuit
                    ? GameEndReason.ApplicationQuit
                    : GameEndReason.Death;
            
            var result = Result.New()
                .WithScore(game.Score)
                .WithEndReason(reason)
                .WithTimeSpent(meta.TimeSpent);
            
            Results.Add(result);

            game.isGameOver = true;
        }
    }
}