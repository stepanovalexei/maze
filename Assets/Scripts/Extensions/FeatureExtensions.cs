using Entitas;

namespace Extensions
{
    public static class FeatureExtensions
    {
        public static void AddInitializeSystems(this Feature feature, params IInitializeSystem[] systems)
        {
            foreach (var system in systems)
                feature.Add(system);
        }
        
        public static void AddExecuteSystems(this Feature feature, params IExecuteSystem[] systems)
        {
            foreach (var system in systems)
                feature.Add(system);
        }
        
        public static void AddCleanupSystems(this Feature feature, params ICleanupSystem[] systems)
        {
            foreach (var system in systems)
                feature.Add(system);
        }
        
        public static void AddTearDownSystems(this Feature feature, params ITearDownSystem[] systems)
        {
            foreach (var system in systems)
                feature.Add(system);
        }
        
    }
    
    
}