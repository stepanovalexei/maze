//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Components.HitByMummy hitByMummyComponent = new Components.HitByMummy();

    public bool isHitByMummy {
        get { return HasComponent(GameComponentsLookup.HitByMummy); }
        set {
            if (value != isHitByMummy) {
                var index = GameComponentsLookup.HitByMummy;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : hitByMummyComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherHitByMummy;

    public static Entitas.IMatcher<GameEntity> HitByMummy {
        get {
            if (_matcherHitByMummy == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.HitByMummy);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherHitByMummy = matcher;
            }

            return _matcherHitByMummy;
        }
    }
}
