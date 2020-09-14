using Entitas;
using Extensions;
using UnityEngine;

namespace Systems.Gameplay.Enemy
{
    public class InstantiateMummy : IExecuteSystem
    {
        private readonly GameContext game;
        private readonly GameObject prefab;
        private readonly IGroup<GameEntity> emptyBlocks;
        private readonly IGroup<GameEntity> spawnMummies;

        public InstantiateMummy(GameContext game, GameObject prefab)
        {
            this.game = game;
            this.prefab = prefab;
            emptyBlocks = game.GetGroup(GameMatcher.AllOf(GameMatcher.Cell).NoneOf(GameMatcher.Wall));
            spawnMummies = game.GetGroup(GameMatcher.SpawnMummy);
        }

        public void Execute()
        {
            foreach (var spawnMummy in spawnMummies)
            {
                var randomTile = emptyBlocks.AsEnumerable().PickRandom();
                var position = randomTile.WorldPosition;
                Object.Instantiate(prefab, position, Quaternion.identity);
            }
        }
    }
}