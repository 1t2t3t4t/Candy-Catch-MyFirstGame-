using System;
using UnityEngine;

namespace Scripts
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Shared;

        private int _score = 0;
        
        public bool IsGameOver { get; private set; } = false;

        private void Awake()
        {
            if (Shared == null)
                Shared = this;
        }

        public void IncreaseScore()
        {
            _score++;
        }

        public void GameOver()
        {
            IsGameOver = true;
        }
    }
}