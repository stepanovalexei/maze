using UnityEngine;

namespace Components.ComponentRegistrators
{
    public class CharacterControllerRegistrator : MonoBehaviour, IComponentRegistrator
    {
        public CharacterController CharacterController;
    
        public void Register(GameEntity entity) =>
            entity.AddCharacterController(CharacterController);
    }
}