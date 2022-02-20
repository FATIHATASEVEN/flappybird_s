using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier_script : MonoBehaviour
{
    public float speed;
    
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
