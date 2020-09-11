using Entitas;

namespace Systems.Gameplay.Map
{
        public class EndlessCoinSpawnTimer : IExecuteSystem
        {
            private readonly GameContext game;
            private readonly float executeInterval;
            private float timeSinceLastExecute = 0;

            public EndlessCoinSpawnTimer(GameContext game, float periodInSeconds)
            {
                this.game = game;
                executeInterval = periodInSeconds;
            }

            public void Execute()
            {
                timeSinceLastExecute += game.Time.DeltaTime;
                if (timeSinceLastExecute > executeInterval)
                {
                    timeSinceLastExecute = 0;
                    game.mapEntity.SpawnCoin = true;
                }
            }
    }
}