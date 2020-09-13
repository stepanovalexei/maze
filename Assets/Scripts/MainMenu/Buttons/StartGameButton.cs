using UnityEngine;
using UnityEngine.SceneManagement;
using static Constants;

namespace MainMenu.Buttons
{
    public class StartGameButton : MonoBehaviour
    {
        public void StartGame() => SceneManager.LoadScene(gameSceneIndex);
    }
}