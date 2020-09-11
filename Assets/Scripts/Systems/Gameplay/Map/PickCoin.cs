using Entitas;

namespace Systems.Gameplay.Map
{
    public class PickCoin : IExecuteSystem
    {
        private readonly GameContext game;
        private readonly MetaContext meta;
        private readonly IGroup<GameEntity> coins;
        private readonly IGroup<GameEntity> scores;

        public PickCoin(GameContext game, MetaContext meta)
        {
            this.game = game;
            this.meta = meta;
            coins = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Coin, GameMatcher.Picked));
            scores = game.GetGroup(GameMatcher.Score);
        }

        public void Execute()
        {
            foreach (var coin in coins.GetEntities())
            foreach (var score in scores.GetEntities())
            {
                coin.isDestructed = true;
                score.score.Value += 1;
                
                coin.isPicked = false;
            }
        }
    }
    // public class CountScore : IExecuteSystem
    // {
    //     private readonly GameContext game;
    //     private readonly MetaContext meta;
    //     private readonly IGroup<GameEntity> coins;
    //     private readonly IGroup<MetaEntity> scores;
    //
    //     public CountScore(GameContext game, MetaContext meta)
    //     {
    //         this.game = game;
    //         this.meta = meta;
    //         coins = game.GetGroup(GameMatcher
    //             .AllOf(GameMatcher.Coin, GameMatcher.Picked));
    //         scores = meta.GetGroup(MetaMatcher.Score);
    //     }
    //
    //     public void Execute()
    //     {
    //         foreach (var coin in coins)
    //         foreach (var score in scores)
    //         {
    //             score.score.Value += 1 ;
    //         }
    //     }
    // }
}