using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciling : MonoBehaviour
{
    public Transform ground;
    public Transform ceiling;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ceiling.position = new Vector3(ground.position.x, ceiling.position.y, 0);        
    }
}
