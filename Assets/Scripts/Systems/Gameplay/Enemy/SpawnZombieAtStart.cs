using Entitas;
using Entity;
using Extensions;
using UnityEngine;

namespace Systems.Gameplay.Enemy
{
    public class SpawnZombieAtStart : IExecuteSystem
    {
        private readonly GameContext game;
        private readonly GameObject prefab;
        private readonly IGroup<GameEntity> mapFinished;

        public SpawnZombieAtStart(GameContext game)
        {
            this.game = game;
            mapFinished = game.GetGroup(GameMatcher.MapBuilded);
        }

        public void Execute()
        {
            foreach (var map in mapFinished)
                CreateEntity
                    .Empty()
                    .With(x => x.SpawnZombie = true);
        }
    }
}