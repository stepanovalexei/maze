using Entitas;
using Extensions;
using UnityEngine;

namespace Systems.Gameplay.Map
{
    public class InstantiateCoin : IExecuteSystem
    {
        private readonly GameContext game;
        private readonly IGroup<GameEntity> maps;
        private readonly IGroup<GameEntity> grounds;
        private readonly GameObject coinPrefab;

        public InstantiateCoin(GameContext game, GameObject coinPrefab)
        {
            this.game = game;
            this.coinPrefab = coinPrefab;
            maps = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.SpawnsCoins, GameMatcher.SpawnCoin));
            grounds = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Cell).NoneOf(GameMatcher.Wall));
        }

        public void Execute()
        {
            foreach (var map in maps.GetEntities())
            {
                var cell = grounds.AsEnumerable().PickRandom();
                cell.isHasCoin = true;

                Object.Instantiate(coinPrefab, map.tilemap.value.GetCellCenterWorld(cell.Cell), Quaternion.identity);
            }
        }
    }
}