using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockscript : MonoBehaviour
{
    public float movee;

    void FixedUpdate()
    {
        transform.position += Vector3.left * movee * Time.deltaTime;
    }
}
