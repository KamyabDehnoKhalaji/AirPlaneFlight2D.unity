using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSound : MonoBehaviour
{
    private Sprite soundOnImage;
    public Sprite soundOffImage;
    public Button button;
    private bool isOn = true;

    public GameObject audioSource;
    public GameObject musicAudioSource;



    void Start()
    {
        soundOnImage = button.image.sprite;
    }

    
    void Update()
    {
        
    }
    public void ButtonClicked()
     {
    if (isOn)
    {
    button.image.sprite = soundOffImage;
    isOn = false;
    audioSource.SetActive( false);
	musicAudioSource.SetActive( false);

    }
    else
    {

      button.image.sprite = soundOnImage;
    isOn = true;
    audioSource.SetActive( true);
	musicAudioSource.SetActive( true);

      }
    }
}
