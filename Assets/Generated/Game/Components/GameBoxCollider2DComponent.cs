//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.BoxCollider2DComponent boxCollider2D { get { return (Components.BoxCollider2DComponent)GetComponent(GameComponentsLookup.BoxCollider2D); } }
    public bool hasBoxCollider2D { get { return HasComponent(GameComponentsLookup.BoxCollider2D); } }

    public GameEntity AddBoxCollider2D(UnityEngine.BoxCollider2D newValue) {
        var index = GameComponentsLookup.BoxCollider2D;
        var component = (Components.BoxCollider2DComponent)CreateComponent(index, typeof(Components.BoxCollider2DComponent));
        component.value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceBoxCollider2D(UnityEngine.BoxCollider2D newValue) {
        var index = GameComponentsLookup.BoxCollider2D;
        var component = (Components.BoxCollider2DComponent)CreateComponent(index, typeof(Components.BoxCollider2DComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveBoxCollider2D() {
        RemoveComponent(GameComponentsLookup.BoxCollider2D);
        return this;
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

    public Components.BoxCollider2DComponent boxCollider2D { get { return (Components.BoxCollider2DComponent)GetComponent(GameComponentsLookup.BoxCollider2D); } }
    public bool hasBoxCollider2D { get { return HasComponent(GameComponentsLookup.BoxCollider2D); } }

    public void AddBoxCollider2D(UnityEngine.BoxCollider2D newValue) {
        var index = GameComponentsLookup.BoxCollider2D;
        var component = (Components.BoxCollider2DComponent)CreateComponent(index, typeof(Components.BoxCollider2DComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBoxCollider2D(UnityEngine.BoxCollider2D newValue) {
        var index = GameComponentsLookup.BoxCollider2D;
        var component = (Components.BoxCollider2DComponent)CreateComponent(index, typeof(Components.BoxCollider2DComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveBoxCollider2D() {
        RemoveComponent(GameComponentsLookup.BoxCollider2D);
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

    static Entitas.IMatcher<GameEntity> _matcherBoxCollider2D;

    public static Entitas.IMatcher<GameEntity> BoxCollider2D {
        get {
            if (_matcherBoxCollider2D == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.BoxCollider2D);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBoxCollider2D = matcher;
            }

            return _matcherBoxCollider2D;
        }
    }
}
