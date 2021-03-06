//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Components.ChaseThePlayer chaseThePlayerComponent = new Components.ChaseThePlayer();

    public bool isChaseThePlayer {
        get { return HasComponent(GameComponentsLookup.ChaseThePlayer); }
        set {
            if (value != isChaseThePlayer) {
                var index = GameComponentsLookup.ChaseThePlayer;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : chaseThePlayerComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherChaseThePlayer;

    public static Entitas.IMatcher<GameEntity> ChaseThePlayer {
        get {
            if (_matcherChaseThePlayer == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ChaseThePlayer);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherChaseThePlayer = matcher;
            }

            return _matcherChaseThePlayer;
        }
    }
}
