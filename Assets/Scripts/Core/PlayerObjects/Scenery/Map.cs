using Extensions;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Core.PlayerObjects.Scenery
{
    public class Map : EntityBehaviour
    {
        public Tilemap Tilemap;
        public Tile GroundTile;
        public Tile WallTile;

        protected override void OnStart()
        {
            var map = Maps
                .NewSet()
                .Random();

            Build(map);

            Entity
                .With(x => x.isMap = true)
                .With(x => x.isMapBuilded = true)
                .With(x => x.SpawnsCoins = true)
                .AddPosition(transform.position)
                .AddTransform(transform)
                .AddMaxCoinCount(10)
                .AddTilemap(Tilemap);
        }

        private void Build(int[,] map)
        {
            var width = map.GetLength(0);
            var height = map.GetLength(1);

            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                {
                    var isWall = map[x, y] == 1;
                    var tile = isWall
                        ? WallTile
                        : GroundTile;
                    var cellPosition = new Vector3Int(x, y, 0);
                    Tilemap.SetTile(cellPosition, tile);

                    Game.CreateEntity()
                        .AddCell(cellPosition)
                        .AddWorldPosition(Tilemap.GetCellCenterWorld(cellPosition))
                        .Do(entity => entity.isWall = true, isWall);
                }
            }
        }
    }
}