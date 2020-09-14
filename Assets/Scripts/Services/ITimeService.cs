using System;

namespace Services
{
    public interface ITimeService
    {
        float DeltaTime { get; }
        DateTime UtcNow { get; }
    }
}