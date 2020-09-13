using Entitas;

namespace Systems.Gameplay.Map
{
    public class UpdateScore : IExecuteSystem
    {
        private readonly GameContext game;
        private readonly IGroup<GameEntity> scores;

        public UpdateScore(GameContext game)
        {
            this.game = game;
            scores = game.GetGroup(GameMatcher.Score);
        }

        public void Execute()
        {
            foreach (var score in scores.GetEntities())
                score.text.Value.text = $"Score: {score.Score}";
        }
    }
}