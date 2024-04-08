using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Player, Button1, Button2, bestText, scoreText;


    public static bool started;
    void Start(){
        started = false;
        //Time.timeScale = 0f;
    }

    public void StartGame()
    {
        Player.SetActive(true);
        Destroy(Button1);
        Destroy(Button2);
        Destroy(bestText);
        scoreText.SetActive(true);
        //Time.timeScale = 1f;
        started = true;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
