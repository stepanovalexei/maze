using System;
using Entitas;
using Entitas.CodeGeneration.Attributes;
using Services;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;
using View;
using static Entitas.CodeGeneration.Attributes.CleanupMode;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Components
{
    // ReSharper disable InconsistentNaming
  
// Services
    [Unique] public class Time : IComponent, IService { public ITimeService Value; }
    [Unique] public class CollidingViewRegister : IComponent, IService { public IRegisterService<IView> Value; }
    [Unique, Input] public class Input : IComponent, IService { public IInputService Value; }
    
// Input  
    [Unique, Input] public class Keyboard : IComponent { }
    [Input] public class Horizontal : IComponent { public float Value; }
    [Input] public class Vertical : IComponent { public float Value; }
    [Input] public class Escape : IComponent { }
  
// Gameplay       
    public class Player : IComponent {}
    public class Coin : IComponent {}
    [FlagPrefix("")]public class SpawnsCoins : IComponent {}
    [FlagPrefix("")][Cleanup(RemoveComponent)]public class SpawnCoin : IComponent {}
    public class MaxCoinCount : IComponent { public int Value; }
    [Cleanup(RemoveComponent)]public class Picked : IComponent {}


    public class Enemy : IComponent {}
    public class Zombie : IComponent {}
    public class Mummy : IComponent {}
    
    [Cleanup(RemoveComponent)]public class HitByMummy : IComponent {}
    [FlagPrefix("")][Cleanup(DestroyEntity)]public class SpawnZombie : IComponent {}
    [FlagPrefix("")][Cleanup(DestroyEntity)]public class SpawnMummy : IComponent {}

    public class WalkSpeed : IComponent { public float Value; }

    [Cleanup(RemoveComponent)]public class ChaseThePlayer : IComponent {}
    public class Chasing : IComponent {}
    public class CurrentPosition : IComponent { public Vector3Int value; }
    public class PreviousPosition : IComponent { public Vector3Int value; }
    public class Target : IComponent { public Vector3 value; }
    public class MoveComplete : IComponent {}
    [Cleanup(RemoveComponent)]public class Dead : IComponent {}
    
    
    [Unique]public class Map : IComponent { }
    [Cleanup(RemoveComponent)]public class MapBuilded : IComponent { }
    public class Cell : IComponent { [EntityIndex] public Vector3Int Value; }
    public class WorldPosition : IComponent { [EntityIndex] public Vector3 Value; }
    public class Ground : IComponent {}
    public class Wall : IComponent {}
    public class HasCoin : IComponent {}
    
    public class RigidbodyComponent : IComponent { public Rigidbody2D value; }
    public class TransformComponent : IComponent { public Transform value; }
    public class TilemapComponent : IComponent { public Tilemap value; }
    public class BoxCollider2DComponent : IComponent { public BoxCollider2D value; }
  
    [Event(Self)] public class Moving : IComponent{ }
    [Event(Self)] public class StoppedMoving : IComponent{ }
    [Event(Self)] public class Direction : IComponent { public float Value; }
    [Event(Self)] public class Position : IComponent { public Vector3 Value; }
    [Event(Self)][Cleanup(DestroyEntity)] public class Destructed : IComponent { }

    
    [Game][Unique] public class Score : IComponent { public int Value; }
    [Game] public class Text : IComponent { public TextMeshProUGUI Value; }
    
// Meta    
    [Game][Unique] public class GameOver : IComponent { }
    [Cleanup(RemoveComponent)][Unique] public class Quit : IComponent { }
    [Meta][Unique] public class TimeStarted : IComponent { public DateTime Value; }
    [Meta][Unique] public class TimeSpent : IComponent { public float Value; }
    [Meta][Unique] public class ScoreView : IComponent {}

    
    [Cleanup(RemoveComponent)][Unique]public class OnApplicationQuit : IComponent {}
    [Cleanup(RemoveComponent)]public class SaveResults : IComponent {}
    
}