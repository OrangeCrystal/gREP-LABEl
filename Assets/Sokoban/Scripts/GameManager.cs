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

        private boo