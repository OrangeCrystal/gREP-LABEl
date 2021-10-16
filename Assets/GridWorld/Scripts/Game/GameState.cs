using Common.Core;
using Common.Enumeration;
using UnityEngine;

namespace GridWorld.Game
{
    public class GameState : IGameState<GameState>
    {
        public TileType[,] Grid;
        public Vector2Int AgentPos;

        public GameState Copy()
        {
            return new GameState
            {
                Grid = G