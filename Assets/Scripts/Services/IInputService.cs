namespace Services
{
    public interface IInputService
    {
        float Vertical { get; }
        float Horizontal { get; }

        bool GetEscapeButtonDown();
    }
}