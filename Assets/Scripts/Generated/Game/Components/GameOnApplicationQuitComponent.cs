//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity onApplicationQuitEntity { get { return GetGroup(GameMatcher.OnApplicationQuit).GetSingleEntity(); } }

    public bool isOnApplicationQuit {
        get { return onApplicationQuitEntity != null; }
        set {
            var entity = onApplicationQuitEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isOnApplicationQuit = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Components.OnApplicationQuit onApplicationQuitComponent = new Components.OnApplicationQuit();

    public bool isOnApplicationQuit {
        get { return HasComponent(GameComponentsLookup.OnApplicationQuit); }
        set {
            if (value != isOnApplicationQuit) {
                var index = GameComponentsLookup.OnApplicationQuit;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : onApplicationQuitComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherOnApplicationQuit;

    public static Entitas.IMatcher<GameEntity> OnApplicationQuit {
        get {
            if (_matcherOnApplicationQuit == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.OnApplicationQuit);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherOnApplicationQuit = matcher;
            }

            return _matcherOnApplicationQuit;
        }
    }
}
