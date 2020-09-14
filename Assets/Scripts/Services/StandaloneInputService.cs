using UnityEngine;

namespace Services
{
    public class StandaloneInputService : IInputService
    {
        public float Vertical => Input.GetAxisRaw("Vertical");
        public float Horizontal => Input.GetAxisRaw("Horizontal");

        public bool GetEscapeButtonDown() => Input.GetKeyDown(KeyCode.Escape);
    }
}