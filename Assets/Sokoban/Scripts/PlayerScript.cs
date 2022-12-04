using Common.Core;
using Common.Enumeration;
using Sokoban.Agent;
using Sokoban.Game;
using UnityEngine;

namespace Sokoban
{
    public class PlayerScript : MonoBehaviour
    {
        private PlayerAgent _agent;
        public GameManager GameManager { g