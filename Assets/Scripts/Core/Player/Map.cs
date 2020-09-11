using System.Collections.Generic;
using Entity;
using Extensions;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Core.Player
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
                .With(x => x.SpawnsCoins = true)
                .With(x => x.isMap = true)
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
                    Tilemap.SetTile(new Vector3Int(x, y, 0), tile);

                    Game.CreateEntity()
                        .AddCell(new Vector3Int(x, y, 0))
                        .Do(entity => entity.isWall = true, isWall);
                }
            }
        }
    }
}