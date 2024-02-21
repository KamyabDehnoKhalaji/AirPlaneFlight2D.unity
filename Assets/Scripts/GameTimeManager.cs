using UnityEngine;

public class GameTimeManager : MonoBehaviour
{
    public GameObject Plane;

    void Start()
    {
        MinusTime();
    }

    void MinusTime()
    {
        if (Plane.activeInHierarchy && GetComponent<PipeSpawner>().maxTime > 1.5f)
        {
            GetComponent<PipeSpawner>().maxTime -= Random.Range(0.07f, 0.2f);
        }

        Invoke("MinusTime", Random.Range(2f, 5f));
    }
}
