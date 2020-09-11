using Entitas;

namespace Systems.Gameplay.Input
{
    public class RegisterInputsSystem : IInitializeSystem
    {
        private readonly InputContext input;

        public RegisterInputsSystem(InputContext input) => this.input = input;

        public void Initialize() => input.isKeyboard = true;
    }
}