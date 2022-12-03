using UnityEngine;

namespace Sokoban
{
    public class Level6Preset : ALevelPreset
    {
        public Level6Preset()
        {
            Grid = new TileType[,]{
                { TileType.Wall, TileType.Wall, TileType.Wall, TileType.Wall, TileType.Wall},
                { TileType.Wall, TileType.Ground, TileType.Ground, TileType.Ground, TileType.Wall},
                { TileType.Wall, Til