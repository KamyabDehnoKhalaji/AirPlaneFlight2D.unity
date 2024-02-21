using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private bool CanAdd = true;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (CanAdd)
            {
                CanAdd = false;
                collision.GetComponent<Fly>().AddScore();
            }
        }
    }
}
