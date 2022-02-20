using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldscript : MonoBehaviour
{

    public float move;

    void FixedUpdate()
    {
        transform.position += Vector3.left * move * Time.deltaTime;
    }
   

}
