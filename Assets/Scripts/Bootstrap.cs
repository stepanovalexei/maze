using Systems.Gameplay;
using Core.Prefabs;
using Entity;
using Services;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    public Prefabs Prefabs;
    
    private Entitas.Systems systems;
    private Services.Services services;

    private void Awake()
    {
        services = new Services.Services
        {
            Time = new UnityTimeService(),
            CollidingViewRegister = new UnityCollidingViewRegister(),
            Identifiers = new GameIdentifierService(),
            InputService = new StandaloneInputService(),
        };

        systems = new MazeFeature
        (
            Contexts.sharedInstance.game,
            Contexts.sharedInstance.meta,
            Contexts.sharedInstance.input,
            services,
            Prefabs
        );

        systems.Initialize();
    }

    private void Update()
    {
        systems.Execute();
        systems.Cleanup();
    }

    private void OnDestroy() => systems.Cleanup();
    
    private void OnApplicationQuit()
    {
        CreateEntity.Empty().isOnApplicationQuit = true;

        systems.Execute();
        systems.Cleanup();
    }

}