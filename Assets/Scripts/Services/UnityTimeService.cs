using System;
using Services;
using UnityEngine;

public class UnityTimeService : ITimeService
{
    public float DeltaTime => Time.deltaTime;
    public DateTime UtcNow => DateTime.UtcNow;
}