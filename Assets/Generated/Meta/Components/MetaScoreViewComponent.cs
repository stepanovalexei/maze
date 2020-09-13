//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MetaContext {

    public MetaEntity scoreViewEntity { get { return GetGroup(MetaMatcher.ScoreView).GetSingleEntity(); } }

    public bool isScoreView {
        get { return scoreViewEntity != null; }
        set {
            var entity = scoreViewEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isScoreView = true;
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
public partial class MetaEntity {

    static readonly Components.ScoreView scoreViewComponent = new Components.ScoreView();

    public bool isScoreView {
        get { return HasComponent(MetaComponentsLookup.ScoreView); }
        set {
            if (value != isScoreView) {
                var index = MetaComponentsLookup.ScoreView;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : scoreViewComponent;

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
public sealed partial class MetaMatcher {

    static Entitas.IMatcher<MetaEntity> _matcherScoreView;

    public static Entitas.IMatcher<MetaEntity> ScoreView {
        get {
            if (_matcherScoreView == null) {
                var matcher = (Entitas.Matcher<MetaEntity>)Entitas.Matcher<MetaEntity>.AllOf(MetaComponentsLookup.ScoreView);
                matcher.componentNames = MetaComponentsLookup.componentNames;
                _matcherScoreView = matcher;
            }

            return _matcherScoreView;
        }
    }
}
