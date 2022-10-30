using UnityEngine;

namespace Sokoban
{
	public class Level2Preset : ALevelPreset
	{
		public Level2Preset()
		{
			Grid = new TileType[,]{
				{ TileType.Wall, TileType.Wall, TileType.Wall, TileType.Wall, TileType.Wall, TileType.Wall, TileType.Wall, Tile