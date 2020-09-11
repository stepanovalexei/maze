using Extensions;

namespace Systems.Gameplay.Input
{
    public class InputFeature : Feature
    {
        public InputFeature(InputContext context)
        {
            this.AddInitializeSystems(new RegisterInputsSystem(context));
            this.AddExecuteSystems(new EmitInputSystem(context));
        }
    }
}