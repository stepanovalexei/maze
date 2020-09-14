using Entitas;

namespace Systems.Gameplay.Statistics
{
    public class CountTimeFromStart : IExecuteSystem, IInitializeSystem
    {
        private readonly MetaContext meta;
        private readonly GameContext game;
        private float timePlayed;

        public CountTimeFromStart(MetaContext meta, GameContext game)
        {
            this.meta = meta;
            this.game = game;
        }

        public void Initialize()
        {
            meta.ReplaceTimeStarted(game.Time.UtcNow);
            meta.ReplaceTimeSpent(0f);
        }

        public void Execute() => meta.ReplaceTimeSpent(meta.TimeSpent + game.Time.DeltaTime);
    }
}