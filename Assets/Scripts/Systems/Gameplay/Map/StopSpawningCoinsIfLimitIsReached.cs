using Entitas;
using UnityEngine;

namespace Systems.Gameplay.Map
{
    public class StopSpawningCoinsIfLimitIsReached : IExecuteSystem
    {
        private readonly IGroup<GameEntity> maps;
        private readonly IGroup<GameEntity> coins;

        public StopSpawningCoinsIfLimitIsReached(GameContext game)
        {
            maps = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Map, GameMatcher.MaxCoinCount));
            coins = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Coin));
        }

        public void Execute()
        {
            foreach (var map in maps)
            foreach (var coin in coins)
                map.SpawnsCoins = coins.count < map.MaxCoinCount;
        }
    }
}