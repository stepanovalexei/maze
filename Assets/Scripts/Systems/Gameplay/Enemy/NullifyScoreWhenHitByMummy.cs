using Entitas;
using UnityEngine;

namespace Systems.Gameplay.Enemy
{
    public class NullifyScoreWhenHitByMummy : IExecuteSystem
    {
        private readonly GameContext game;
        private readonly GameObject prefab;
        private readonly IGroup<GameEntity> hits;
        private readonly IGroup<GameEntity> scores;

        public NullifyScoreWhenHitByMummy(GameContext game)
        {
            this.game = game;
            hits = game.GetGroup(GameMatcher.HitByMummy);
            scores = game.GetGroup(GameMatcher.Score);
        }

        public void Execute()
        {
            foreach (var hit in hits)
            foreach (var score in scores)
                score.ReplaceScore(0);
        }
    }
}