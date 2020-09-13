//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Components.StoppedMoving stoppedMovingComponent = new Components.StoppedMoving();

    public bool isStoppedMoving {
        get { return HasComponent(GameComponentsLookup.StoppedMoving); }
        set {
            if (value != isStoppedMoving) {
                var index = GameComponentsLookup.StoppedMoving;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : stoppedMovingComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherStoppedMoving;

    public static Entitas.IMatcher<GameEntity> StoppedMoving {
        get {
            if (_matcherStoppedMoving == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.StoppedMoving);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherStoppedMoving = matcher;
            }

            return _matcherStoppedMoving;
        }
    }
}
