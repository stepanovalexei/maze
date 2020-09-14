using Entitas;
using Extensions;
using UnityEngine;

namespace Systems.Gameplay.Enemy
{
    public class InstantiateZombie : IExecuteSystem
    {
        private readonly GameContext game;
        private readonly GameObject prefab;
        private readonly IGroup<GameEntity> emptyBlocks;
        private readonly IGroup<GameEntity> spawnZombies;

        public InstantiateZombie(GameContext game, GameObject prefab)
        {
            this.game = game;
            this.prefab = prefab;
            emptyBlocks = game.GetGroup(GameMatcher.AllOf(GameMatcher.Cell).NoneOf(GameMatcher.Wall));
            spawnZombies = game.GetGroup(GameMatcher.SpawnZombie);
        }

        public void Execute()
        {
            foreach (var spawnZomby in spawnZombies)
            {
                var randomTile = emptyBlocks.AsEnumerable().PickRandom();
                var position = randomTile.WorldPosition;
                Object.Instantiate(prefab, position, Quaternion.identity);
            }
        }
    }
}