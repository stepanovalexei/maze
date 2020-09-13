//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity scoreEntity { get { return GetGroup(GameMatcher.Score).GetSingleEntity(); } }
    public Components.Score score { get { return scoreEntity.score; } }
    public int Score { get { return score.Value; } }
    public bool hasScore { get { return scoreEntity != null; } }

    public GameEntity SetScore(int newValue) {
        if (hasScore) {
            throw new Entitas.EntitasException("Could not set Score!\n" + this + " already has an entity with Components.Score!",
                "You should check if the context already has a scoreEntity before setting it or use context.ReplaceScore().");
        }
        var entity = CreateEntity();
        entity.AddScore(newValue);
        return entity;
    }

    public void ReplaceScore(int newValue) {
        var entity = scoreEntity;
        if (entity == null) {
            entity = SetScore(newValue);
        } else {
            entity.ReplaceScore(newValue);
        }
    }

    public void RemoveScore() {
        scoreEntity.Destroy();
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

    public Components.Score score { get { return (Components.Score)GetComponent(GameComponentsLookup.Score); } }
    public int Score { get { return score.Value; } }
    public bool hasScore { get { return HasComponent(GameComponentsLookup.Score); } }

    public GameEntity AddScore(int newValue) {
        var index = GameComponentsLookup.Score;
        var component = (Components.Score)CreateComponent(index, typeof(Components.Score));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceScore(int newValue) {
        var index = GameComponentsLookup.Score;
        var component = (Components.Score)CreateComponent(index, typeof(Components.Score));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveScore() {
        RemoveComponent(GameComponentsLookup.Score);
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

    static Entitas.IMatcher<GameEntity> _matcherScore;

    public static Entitas.IMatcher<GameEntity> Score {
        get {
            if (_matcherScore == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Score);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherScore = matcher;
            }

            return _matcherScore;
        }
    }
}
