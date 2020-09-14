using Extensions;

namespace Systems.Gameplay.Input
{
    public class InputFeature : Feature
    {
        public InputFeature(InputContext context, GameContext game)
        {
            this.AddInitializeSystems(new RegisterInputsSystem(context));
            
            this.AddExecuteSystems(
                new EmitInputSystem(context),
                new QuitGameOnEscape(context, game));
        }
    }
}