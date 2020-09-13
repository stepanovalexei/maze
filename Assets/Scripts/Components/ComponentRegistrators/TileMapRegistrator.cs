using UnityEngine;
using UnityEngine.Tilemaps;

namespace Components.ComponentRegistrators
{
    public class TileMapRegistrator : MonoBehaviour, IComponentRegistrator
    {
        public Tilemap Tilemap;
    
        public void Register(GameEntity entity) =>
            entity.AddTilemap(Tilemap);
    }
}