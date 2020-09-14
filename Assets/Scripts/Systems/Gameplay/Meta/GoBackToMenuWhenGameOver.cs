using System.Collections.Generic;
using Entitas;
using MainMenu.Results;
using UnityEngine.SceneManagement;
using static Constants;
using static MainMenu.Results.GameEndReason;

namespace Systems.Gameplay.Statistics
{
    public class GoBackToMenuWhenGameOver : ReactiveSystem<GameEntity>
    {
        private readonly MetaContext meta;
        private readonly GameContext game;
        private float timePlayed;

        public GoBackToMenuWhenGameOver(MetaContext meta, GameContext game) : base(game)
        {
            this.meta = meta;
            this.game = game;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
            context.CreateCollector(GameMatcher.GameOver.Added());

        protected override bool Filter(GameEntity entity) =>
            entity.isGameOver;
        protected override void Execute(List<GameEntity> entities) => 
            SceneManager.LoadScene(menuSceneIndex);
    }
}