//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public MovingListenerComponent movingListener { get { return (MovingListenerComponent)GetComponent(GameComponentsLookup.MovingListener); } }
    public bool hasMovingListener { get { return HasComponent(GameComponentsLookup.MovingListener); } }

    public GameEntity AddMovingListener(System.Collections.Generic.List<IMovingListener> newValue) {
        var index = GameComponentsLookup.MovingListener;
        var component = (MovingListenerComponent)CreateComponent(index, typeof(MovingListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceMovingListener(System.Collections.Generic.List<IMovingListener> newValue) {
        var index = GameComponentsLookup.MovingListener;
        var component = (MovingListenerComponent)CreateComponent(index, typeof(MovingListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveMovingListener() {
        RemoveComponent(GameComponentsLookup.MovingListener);
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

    static Entitas.IMatcher<GameEntity> _matcherMovingListener;

    public static Entitas.IMatcher<GameEntity> MovingListener {
        get {
            if (_matcherMovingListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MovingListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMovingListener = matcher;
            }

            return _matcherMovingListener;
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

    public void AddMovingListener(IMovingListener value) {
        var listeners = hasMovingListener
            ? movingListener.value
            : new System.Collections.Generic.List<IMovingListener>();
        listeners.Add(value);
        ReplaceMovingListener(listeners);
    }

    public void RemoveMovingListener(IMovingListener value, bool removeComponentWhenEmpty = true) {
        var listeners = movingListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveMovingListener();
        } else {
            ReplaceMovingListener(listeners);
        }
    }
}
