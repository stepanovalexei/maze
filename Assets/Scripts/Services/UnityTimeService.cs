using System;
using UnityEngine;

namespace Services
{
    public class UnityTimeService : ITimeService
    {
        public float DeltaTime => Time.deltaTime;
        public DateTime UtcNow => DateTime.UtcNow;
    }
}