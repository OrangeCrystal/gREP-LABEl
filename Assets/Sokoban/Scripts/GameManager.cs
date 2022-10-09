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
                for (in