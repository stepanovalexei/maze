using UnityEngine;
using UnityEngine.Tilemaps;

namespace Components.ComponentRegistrators
{
    public class TileMapColliderRegistrator : MonoBehaviour, IComponentRegistrator
    {
        public TilemapCollider2D TilemapCollider2D;
    
        public void Register(GameEntity entity) =>
            entity.AddTilemapCollider2D(TilemapCollider2D);
    }
}