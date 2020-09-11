using UnityEngine;

namespace Services
{
    public interface IInputService
    {
        float Vertical { get; }
        float Horizontal { get; }
        float Jump { get; }

        Vector2 GetScreenMousePosition();
        Vector3 GetWorldMousePosition();

        bool GetLeftMouseButton();
        bool GetLeftMouseButtonDown();
        bool GetLeftMouseButtonUp();

        bool GetRightMouseButton();
        bool GetRightMouseButtonDown();
        bool GetRightMouseButtonUp();
        bool GetEscapeButtonDown();
    }
}