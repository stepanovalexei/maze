//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PositionListenerComponent positionListener { get { return (PositionListenerComponent)GetComponent(GameComponentsLookup.PositionListener); } }
    public bool hasPositionListener { get { return HasComponent(GameComponentsLookup.PositionListener); } }

    public GameEntity AddPositionListener(System.Collections.Generic.List<IPositionListener> newValue) {
        var index = GameComponentsLookup.PositionListener;
        var component = (PositionListenerComponent)CreateComponent(index, typeof(PositionListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplacePositionListener(System.Collections.Generic.List<IPositionListener> newValue) {
        var index = GameComponentsLookup.PositionListener;
        var component = (PositionListenerComponent)CreateComponent(index, typeof(PositionListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemovePositionListener() {
        RemoveComponent(GameComponentsLookup.PositionListener);
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

    static Entitas.IMatcher<GameEntity> _matcherPositionListener;

    public static Entitas.IMatcher<GameEntity> PositionListener {
        get {
            if (_matcherPositionListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PositionListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPositionListener = matcher;
            }

            return _matcherPositionListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddPositionListener(IPositionListener value) {
        var listeners = hasPositionListener
            ? positionListener.value
            : new System.Collections.Generic.List<IPositionListener>();
        listeners.Add(value);
        ReplacePositionListener(listeners);
    }

    public void RemovePositionListener(IPositionListener value, bool removeComponentWhenEmpty = true) {
        var listeners = positionListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemovePositionListener();
        } else {
            ReplacePositionListener(listeners);
        }
    }
}
