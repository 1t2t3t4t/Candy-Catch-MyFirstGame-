using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Shared;

        public Text ScoreText;

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
            ScoreText.text = _score.ToString();
        }

        public void GameOver()
        {
            IsGameOver = true;
        }
    }
}