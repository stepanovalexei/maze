using UnityEngine;

namespace Core.Player
{
    public class PlayerAnimator : MonoBehaviour
    {
        private readonly int isMovingHash = Animator.StringToHash("isMoving");
        
        public Animator Animator;

        public void PlayMove() => Animator.SetBool(isMovingHash, true);

        public void PlayIdle() => Animator.SetBool(isMovingHash, false);
    }
}