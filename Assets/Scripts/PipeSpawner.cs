using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1f;
    [SerializeField] private float height = 0.85f;
    [SerializeField] private GameObject Pipe, Plane;

    private float timer = 0;

    void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            if(Pipe != null)
            {
                if (Plane.activeInHierarchy)
                {
                    SpawnPipe();
                }
            }

            timer = 0;
        }

        timer += Time.deltaTime;
    }

    void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-height, height));
        GameObject pipe = Instantiate(Pipe, spawnPos, Quaternion.identity);

        Destroy(pipe, 25f);
    }
}
