using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scripts.MainMenu
{
    public class MainMenuController : MonoBehaviour
    {
        public void Play()
        {
            SceneManager.LoadScene("Game");
        }

        public void Exit()
        {
            Application.Quit();
        }
    }
}