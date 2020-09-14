using Entitas;

namespace Systems.Gameplay.Input
{
    public class QuitGameOnEscape : IExecuteSystem
    {
        private readonly GameContext game;
        private readonly InputContext inputContext;
        private readonly IGroup<InputEntity> keyboards;

        public QuitGameOnEscape(InputContext inputContext, GameContext game)
        {
            this.game = game;
            this.inputContext = inputContext;
            keyboards = inputContext.GetGroup(InputMatcher.Keyboard);
        }

        public void Execute()
        {
            foreach (var keyboard in keyboards) 
                game.isQuit = keyboard.isEscape;
        }
    }
}