using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int Score = 0;
    public TextMeshProUGUI text, bestText;

    void Update()
    {
        text.text = Score.ToString();

        if (PlayerPrefs.HasKey("Best"))
        {
            bestText.text = "Best: " + PlayerPrefs.GetInt("Best");
        }
        else
        {
            bestText.text = "Best: 0";
        }
    }

    public void AddScore()
    {
        Score++;
    }
}
