using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Player, Button1, Button2, bestText, scoreText;

    void Start()
    {
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        Player.SetActive(true);
        Destroy(Button1);
        Destroy(Button2);
        Destroy(bestText);
        scoreText.SetActive(true);
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
