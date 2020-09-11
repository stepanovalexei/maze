using Systems.Gameplay.Input;
using Systems.Gameplay.Map;
using Systems.Gameplay.Player;
using Systems.ServiceRegistration;
using Core.Prefabs;
using Entitas;
using Extensions;

namespace Systems.Gameplay
{
    public class MazeFeature : Feature
    {
        public MazeFeature(GameContext game, MetaContext meta, InputContext input, Services.Services services,
            Prefabs prefabs)
        {
            Add(new ServiceRegistrationSystems(game, input, services));
            Add(new InputFeature(input));
            Add(new GameplayFeature(game, input, meta, prefabs));
            Add(new StatisticsFeature(game, meta));

            Add(new GameCleanupSystems(Contexts.sharedInstance));
        }
    }

    public class StatisticsFeature : Feature
    {
        public StatisticsFeature(GameContext game, MetaContext meta)
        {
            this.AddExecuteSystems
            (
                // new CountScore(game, meta)
            );
        }
    }

    public class GameplayFeature : Feature
    {
        public GameplayFeature(GameContext game, InputContext input, MetaContext meta, Prefabs prefabs)
        {
            this.AddExecuteSystems
            (
                new MovePlayer(game, input),
                new EndlessCoinSpawnTimer(game, 5f),
                new SpawnCoins(game, prefabs.Coin),
                new StopSpawningCoinsIfLimitIsReached(game),
                new PickCoin(game, meta)
            );
        }
    }
}