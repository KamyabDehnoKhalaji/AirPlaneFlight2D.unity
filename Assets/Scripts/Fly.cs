using TMPro;
using UnityEngine;

public class Fly : MonoBehaviour
{
    [SerializeField] private float velocity = 1f;
    [SerializeField] private float fallDelay = 0.4f;
    [SerializeField] private float rotateSpeed = 1f;

    public GameObject DownRot, UpRot, Panel;
    public TextMeshProUGUI bestText, scoreText;
    public ScoreManager scoreManager;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Tap()
    {
        CancelInvoke("DownRotation");

        transform.rotation = UpRot.transform.rotation;

        rb.velocity = Vector2.up * velocity;

        Invoke("DownRotation", fallDelay);
    }

    void DownRotation()
    {
        transform.rotation = DownRot.transform.rotation;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0f;

        Panel.SetActive(true);

        scoreText.text = "Score: " + scoreManager.Score;

        if (PlayerPrefs.HasKey("Best"))
        {
            if (scoreManager.Score > PlayerPrefs.GetInt("Best"))
            {
                PlayerPrefs.SetInt("Best", scoreManager.Score);

                bestText.text = "Best: " + scoreManager.Score;
            }
            else
            {
                bestText.text = "Best: " + PlayerPrefs.GetInt("Best");
            }
        }
        else
        {
            PlayerPrefs.SetInt("Best", scoreManager.Score);

            bestText.text = "Best: " + scoreManager.Score;
        }
    }

    public void AddScore()
    {
        GameObject.Find("Canvas").GetComponent<ScoreManager>().AddScore();
    }
}
