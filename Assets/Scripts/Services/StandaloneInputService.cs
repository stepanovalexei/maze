using UnityEngine;
using UnityEngine.EventSystems;

namespace Services
{
    public class StandaloneInputService : IInputService
    {
        private readonly Camera mainCamera = Camera.main;
        private Vector3 screenPosition = new Vector3(0, 0, Camera.main.nearClipPlane);

        public float Vertical => Input.GetAxisRaw("Vertical");
        public float Horizontal => Input.GetAxisRaw("Horizontal");
        public float Jump => Input.GetAxisRaw("Jump");

        public Vector2 GetScreenMousePosition() => Input.mousePosition;

        public Vector3 GetWorldMousePosition()
        {
            screenPosition.x = Input.mousePosition.x;
            screenPosition.y = Input.mousePosition.y;
            return mainCamera.ScreenToWorldPoint(screenPosition);
        }

        public bool GetLeftMouseButton() => Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject();

        public bool GetLeftMouseButtonDown() => Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject();

        public bool GetLeftMouseButtonUp() => Input.GetMouseButtonUp(0) && !EventSystem.current.IsPointerOverGameObject();

        public bool GetRightMouseButton() => Input.GetMouseButton(1) && !EventSystem.current.IsPointerOverGameObject();

        public bool GetRightMouseButtonDown() => Input.GetMouseButtonDown(1) && !EventSystem.current.IsPointerOverGameObject();

        public bool GetRightMouseButtonUp() => Input.GetMouseButtonUp(1) && !EventSystem.current.IsPointerOverGameObject();

        public bool GetEscapeButtonDown() => Input.GetKeyDown(KeyCode.Escape);
    }
}