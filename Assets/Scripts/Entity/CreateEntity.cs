﻿namespace Entity
{
    public static class CreateEntity
    {
        public static GameEntity Empty() =>
            Contexts.sharedInstance.game.CreateEntity();
    }
    
    
}

