//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.TilemapCollider2DComponent tilemapCollider2D { get { return (Components.TilemapCollider2DComponent)GetComponent(GameComponentsLookup.TilemapCollider2D); } }
    public bool hasTilemapCollider2D { get { return HasComponent(GameComponentsLookup.TilemapCollider2D); } }

    public GameEntity AddTilemapCollider2D(UnityEngine.Tilemaps.TilemapCollider2D newValue) {
        var index = GameComponentsLookup.TilemapCollider2D;
        var component = (Components.TilemapCollider2DComponent)CreateComponent(index, typeof(Components.TilemapCollider2DComponent));
        component.value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceTilemapCollider2D(UnityEngine.Tilemaps.TilemapCollider2D newValue) {
        var index = GameComponentsLookup.TilemapCollider2D;
        var component = (Components.TilemapCollider2DComponent)CreateComponent(index, typeof(Components.TilemapCollider2DComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveTilemapCollider2D() {
        RemoveComponent(GameComponentsLookup.TilemapCollider2D);
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

    public Components.TilemapCollider2DComponent tilemapCollider2D { get { return (Components.TilemapCollider2DComponent)GetComponent(GameComponentsLookup.TilemapCollider2D); } }
    public bool hasTilemapCollider2D { get { return HasComponent(GameComponentsLookup.TilemapCollider2D); } }

    public void AddTilemapCollider2D(UnityEngine.Tilemaps.TilemapCollider2D newValue) {
        var index = GameComponentsLookup.TilemapCollider2D;
        var component = (Components.TilemapCollider2DComponent)CreateComponent(index, typeof(Components.TilemapCollider2DComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTilemapCollider2D(UnityEngine.Tilemaps.TilemapCollider2D newValue) {
        var index = GameComponentsLookup.TilemapCollider2D;
        var component = (Components.TilemapCollider2DComponent)CreateComponent(index, typeof(Components.TilemapCollider2DComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTilemapCollider2D() {
        RemoveComponent(GameComponentsLookup.TilemapCollider2D);
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

    static Entitas.IMatcher<GameEntity> _matcherTilemapCollider2D;

    public static Entitas.IMatcher<GameEntity> TilemapCollider2D {
        get {
            if (_matcherTilemapCollider2D == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TilemapCollider2D);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTilemapCollider2D = matcher;
            }

            return _matcherTilemapCollider2D;
        }
    }
}
