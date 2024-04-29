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

    
    
    private float UP_Force = 4;
    private float rotationSpeed = 10;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        rb.isKinematic = true;

        
    }

    private float jump = 0;

    public void Tap(){

        rb.velocity = Vector2.up * UP_Force;
    }


    

    void FixedUpdate(){
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * rotationSpeed);
    }
    
    
    
    void Update()
    {
        
        if (Menu.started){
            rb.isKinematic = false;
        }


        if (jump>0){

            //rb.velocity = Vector2.up * UP_Force *Time.deltaTime;
            
            rb.AddForce(Vector2.up * UP_Force *Time.deltaTime , ForceMode2D.Impulse);

            
            jump -= Time.deltaTime;
        }
        
    }
    
    // void DownRotation()
    // {
    //     
    //     
    //     
    //     transform.rotation = DownRot.transform.rotation;
    // }

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
