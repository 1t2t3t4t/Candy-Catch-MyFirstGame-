using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scripts.CandyCatchGame
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Shared;

        public CandySpawner Spawner;
        
        public Text ScoreText;
        public GameObject LifePanel;
        public GameObject GameOverPanel;

        private int _score = 0;
        private int _life = 3;
        
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

        #region Game Over Panel Event

        public void OnClickRestart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void OnClickMainMenu()
        {
            SceneManager.LoadScene("MainMenu");
        }

        #endregion

        public void DecreaseLife()
        {
            if (_life > 0)
            {
                _life--;
                Destroy(LifePanel.transform.GetChild(0).gameObject);
            }
            
            if (_life <= 0)
                GameOver();
        }

        private void GameOver()
        {
            IsGameOver = true;
            Spawner.StopSpawning();
            GameOverPanel.SetActive(true);
        }
    }
}