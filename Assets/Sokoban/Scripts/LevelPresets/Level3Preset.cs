using UnityEngine;

namespace Sokoban
{
	public class Level3Preset : ALevelPreset
	{
		public Level3Preset()
		{
			Grid = new TileType[,]{
				{ TileType.Wall, TileType.Wall, TileType.Wall, TileType.Wall, TileType.Wall, TileType.Wall, TileType.Wall, TileType.Wall}, 
				{ TileType.Wall, TileType.Wall, TileType.Wall, TileType.Ground,  TileType.Ground, TileType.Ground, TileType.Wall, TileType.Wall},
				{ TileType.Wall, TileType.Button, TileType.Ground, TileType.Ground, TileType.Ground, TileType.Ground, TileType.Wall, TileType.Wall},
				{ TileType.Wall, TileType.Wall, TileType.Wall, TileType.Ground, TileType.Ground, TileType.Button, TileType.Wall, TileType.Wall},
				{ TileType.Wall, TileType.Button, TileType.Wall, TileType.Wall, TileType.Ground, TileType.Ground, TileType.Wall, TileType.Wall},
				{ TileType.Wall, TileType.Ground, TileType.Wall, TileType.Ground, TileType.Button, TileType.Ground, Til