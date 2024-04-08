using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back_Move : MonoBehaviour
{
    public float Moving_speed;
    void Start()
    {

    }
    void Update()
    {
        gameObject.transform.Translate(-Moving_speed * Time.deltaTime, 0, 0);
        if (gameObject.transform.position.x <= -12.15f)
        {
            gameObject.transform.position = new Vector2(22.24f, gameObject.transform.position.y);
        }
    }
}