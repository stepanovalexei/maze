using Systems.Gameplay.Enemy;
using Systems.Gameplay.Input;
using Systems.Gameplay.Map;
using Systems.Gameplay.Player;
using Systems.Gameplay.Statistics;
using Systems.ServiceRegistration;
using Extensions;

namespace Systems
{
    public class MazeFeature : Feature
    {
        public MazeFeature(GameContext game, MetaContext meta, InputContext input, Services.Services services,
            Prefabs.Prefabs prefabs)
        {
            Add(new ServiceRegistrationSystems(game, input, services));
            
            Add(new InputFeature(input, game));
            Add(new GameplayFeature(game, input, meta, prefabs));
            Add(new StatisticsFeature(game, meta));

            Add(new GameCleanupSystems(Contexts.sharedInstance));
            Add(new GameEventSystems(Contexts.sharedInstance));
        }
    }

    public class StatisticsFeature : Feature
    {
        public StatisticsFeature(GameContext game, MetaContext meta)
        {
            this.AddExecuteSystems
            (
                new UpdateScore(game),
                new CountTimeFromStart(meta ,game),
                new SaveResultsWhenGameEnds(meta ,game)
            );
        }
    }

    public class GameplayFeature : Feature
    {
        public GameplayFeature(GameContext game, InputContext input, MetaContext meta, Prefabs.Prefabs prefabs)
        {
            this.AddInitializeSystems
            (
            );
            this.AddExecuteSystems
            (
                new MovePlayer(game, input),
                
                new SpawnZombieAtStart(game),
                new SpawnSecondZombieWhenFiveCoinsPicked(game),
                new SpawnMummyWhenTenCoinsPicked(game),
                
                new InstantiateMummy(game, prefabs.Mummy),
                new InstantiateZombie(game, prefabs.Zombie),
                
                new MoveEnemy(game),
                new FindDestinationToMove(game, input),
                
                new SpawnCoinsWithInterval(game, 5f),
                new StopSpawningCoinsIfLimitIsReached(game),
                new InstantiateCoin(game, prefabs.Coin),
                new PickCoin(game, meta)
            );
        }
    }
}