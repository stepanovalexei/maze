using Entitas;
using Services;
using UnityEngine;

namespace Systems.Gameplay.Input
{
    public class EmitInputSystem : IExecuteSystem
    {
        private readonly InputContext inputContext;
        private IInputService Input => inputContext.Input;
        private readonly IGroup<InputEntity> keyboards;

        public EmitInputSystem(InputContext inputContext)
        {
            this.inputContext = inputContext;
            keyboards = inputContext.GetGroup(InputMatcher.Keyboard);
        }

        public void Execute()
        {
            foreach (var keyboard in keyboards)
            {
                var screenPosition = Input.GetScreenMousePosition();
                Vector2 worldPosition = Input.GetWorldMousePosition();

                keyboard.ReplaceHorizontal(Input.Horizontal);
                keyboard.ReplaceVertical(Input.Vertical);
                keyboard.isEscape = Input.GetEscapeButtonDown();
            }
        }
    }
}