using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldspawner : MonoBehaviour
{
    public Bird_scripts birdd;
    public GameObject gold;
    public float height;
    public float time;
    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
    public IEnumerator SpawnObject(float time)
    {
        while (!birdd.isDead)
        {
            Instantiate(gold, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}
