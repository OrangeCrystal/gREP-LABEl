using System;
using Common.Agent.DP;
using Common.Core;
using Common.Enumeration;
using Sokoban.Agent.Plugin;
using Sokoban.Game;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Sokoban
{
    public class GameManager : MonoBehaviour
    {
        public List<TileToPrefab> TileToPrefabs;
        public GameObject playerPrefab;
        public GameObject cratePrefab;
        public ALevelPreset LevelPreset;
        public GameObject displayText;
        public int agentIndex;

        private PlayerScript _player;
        private List<GameObject> _crateInstances = new List<GameObject>();
        private ALevelPreset _levelPreset;
        private AAgent<GameState, GameRules> _agent;
        private int _playFrames = 0;

        private bool _finished = false;

        public readonly GameRules GameRules = new GameRules();

        /// <summary>
        /// Stocke l'état du jeu actuel
        /// </summary>
        public GameState GameState { get; private set; }

        private void Start()
        {
            _levelPreset = Instantiate(LevelPreset, new Vector3(0, 0, 0), Quaternion.identity);
            for (int x = 0; x < _levelPreset.Grid.GetLength(0); ++x)
            {
                for (int y = 0; y < _levelPreset.Grid.GetLength(1); ++y)
                {
                    TileType tileType = _levelPreset.Grid[x, y];
                    foreach (var tile in TileToPrefabs)
                    {

                        if (tile.TileType == tileType)
                        {
                            Instantiate(tile.Prefab, new Vector3(x, tile.Prefab.transform.position.y, y), Quaternion.identity);
                        }
                    }
                }
            }

            foreach (var position in _levelPreset.CrateStartPosition)
            {
                _crateInstances.Add(Instantiate(cratePrefab, new Vector3(position.x, cratePrefab.transform.position.y, position.y),
                    Quaternion.identity));
            }
            _player = Instantiate(playerPrefab, new Vector3(_levelPreset.StartPosition.x, playerPrefab.transform.position.y, _levelPreset.StartPosition.y), Quaternion.identity).GetComponent<PlayerScript>();
            _player.GameManager = this;
            GameState = new GameState
            {
                Grid = _levelPreset.Grid,
                AgentPos = _levelPreset.StartPosition,
                CratePos = _levelPreset.CrateStartPosition
            };

            switch (agentIndex)
            {
                case 0:
                    this._agent = new MDPPolicyAgent<GameState, GameRules>(this.GameRules,  new BaseAgentPlugin(), this.GameState);
                    break;
                case 1:
                    this._agent = new MDPValueAgent<GameState, GameRules>(this.GameRules, new BaseAgentPlugin(), this.GameState);
                    break;
                case 2:
                    break;
