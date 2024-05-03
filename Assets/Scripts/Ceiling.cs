using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciling : MonoBehaviour
{
    public Transform ground;
    public Transform ceiling;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        ceiling.position = new Vector3(ground.position.x, ceiling.position.y, 0);        
    }
}
