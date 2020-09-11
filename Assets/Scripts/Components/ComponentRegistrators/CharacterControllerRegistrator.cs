using UnityEngine;

namespace Components.ComponentRegistrators
{
    public class CharacterControllerRegistrator : MonoBehaviour, IViewComponentRegistrator
    {
        public CharacterController CharacterController;
    
        public void Register(GameEntity entity) =>
            entity.AddCharacterController(CharacterController);
    }
}