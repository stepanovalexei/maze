namespace Entity
{
    internal static class EntityExtensions
    {
        public static GameEntity WithNewId(this GameEntity entity)
        {
            if (entity.hasId)
                return entity;

            entity.AddId(Contexts.sharedInstance.game.Identifiers.Next());

            return entity;
        }
    }
}