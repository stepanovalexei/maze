//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.WalkSpeed walkSpeed { get { return (Components.WalkSpeed)GetComponent(GameComponentsLookup.WalkSpeed); } }
    public float WalkSpeed { get { return walkSpeed.Value; } }
    public bool hasWalkSpeed { get { return HasComponent(GameComponentsLookup.WalkSpeed); } }

    public GameEntity AddWalkSpeed(float newValue) {
        var index = GameComponentsLookup.WalkSpeed;
        var component = (Components.WalkSpeed)CreateComponent(index, typeof(Components.WalkSpeed));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceWalkSpeed(float newValue) {
        var index = GameComponentsLookup.WalkSpeed;
        var component = (Components.WalkSpeed)CreateComponent(index, typeof(Components.WalkSpeed));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveWalkSpeed() {
        RemoveComponent(GameComponentsLookup.WalkSpeed);
        return this;
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

    static Entitas.IMatcher<GameEntity> _matcherWalkSpeed;

    public static Entitas.IMatcher<GameEntity> WalkSpeed {
        get {
            if (_matcherWalkSpeed == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.WalkSpeed);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherWalkSpeed = matcher;
            }

            return _matcherWalkSpeed;
        }
    }
}